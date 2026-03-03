using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppZXing.Common;
using Il2CppZXing.Common.ReedSolomon;

namespace Il2CppZXing.Aztec.Internal;

public static class Encoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_WORD_SIZE;

	private static readonly System.IntPtr NativeMethodInfoPtr_encode_Public_Static_AztecCode_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawBullsEye_Private_Static_Void_BitMatrix_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateModeMessage_Internal_Static_BitArray_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawModeMessage_Private_Static_Void_BitMatrix_Boolean_Int32_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateCheckWords_Private_Static_BitArray_BitArray_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bitsToWords_Private_Static_Il2CppStructArray_1_Int32_BitArray_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getGF_Private_Static_GenericGF_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stuffBits_Internal_Static_BitArray_BitArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TotalBitsInLayer_Private_Static_Int32_Int32_Boolean_0;

	public unsafe static Il2CppStructArray<int> WORD_SIZE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WORD_SIZE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WORD_SIZE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Encoder()
	{
		Il2CppClassPointerStore<Encoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Aztec.Internal", "Encoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoder>.NativeClassPtr);
		NativeFieldInfoPtr_WORD_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoder>.NativeClassPtr, "WORD_SIZE");
		NativeMethodInfoPtr_encode_Public_Static_AztecCode_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100664905);
		NativeMethodInfoPtr_drawBullsEye_Private_Static_Void_BitMatrix_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100664906);
		NativeMethodInfoPtr_generateModeMessage_Internal_Static_BitArray_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100664907);
		NativeMethodInfoPtr_drawModeMessage_Private_Static_Void_BitMatrix_Boolean_Int32_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100664908);
		NativeMethodInfoPtr_generateCheckWords_Private_Static_BitArray_BitArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100664909);
		NativeMethodInfoPtr_bitsToWords_Private_Static_Il2CppStructArray_1_Int32_BitArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100664910);
		NativeMethodInfoPtr_getGF_Private_Static_GenericGF_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100664911);
		NativeMethodInfoPtr_stuffBits_Internal_Static_BitArray_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100664912);
		NativeMethodInfoPtr_TotalBitsInLayer_Private_Static_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100664913);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1430674, RefRangeEnd = 1430676, XrefRangeStart = 1430562, XrefRangeEnd = 1430674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AztecCode encode(Il2CppStructArray<byte> data, int minECCPercent, int userSpecifiedLayers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minECCPercent;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &userSpecifiedLayers;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encode_Public_Static_AztecCode_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AztecCode>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430676, XrefRangeEnd = 1430686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void drawBullsEye(BitMatrix matrix, int center, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawBullsEye_Private_Static_Void_BitMatrix_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430686, XrefRangeEnd = 1430702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BitArray generateModeMessage(bool compact, int layers, int messageSizeInWords)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&compact);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layers;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &messageSizeInWords;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateModeMessage_Internal_Static_BitArray_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430702, XrefRangeEnd = 1430719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void drawModeMessage(BitMatrix matrix, bool compact, int matrixSize, BitArray modeMessage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &compact;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &matrixSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modeMessage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawModeMessage_Private_Static_Void_BitMatrix_Boolean_Int32_BitArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1430759, RefRangeEnd = 1430762, XrefRangeStart = 1430719, XrefRangeEnd = 1430759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BitArray generateCheckWords(BitArray bitArray, int totalBits, int wordSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bitArray);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &totalBits;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wordSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateCheckWords_Private_Static_BitArray_BitArray_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430762, XrefRangeEnd = 1430767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> bitsToWords(BitArray stuffedBits, int wordSize, int totalWords)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stuffedBits);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wordSize;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &totalWords;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bitsToWords_Private_Static_Il2CppStructArray_1_Int32_BitArray_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430767, XrefRangeEnd = 1430771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GenericGF getGF(int wordSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wordSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getGF_Private_Static_GenericGF_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GenericGF>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1430778, RefRangeEnd = 1430780, XrefRangeStart = 1430771, XrefRangeEnd = 1430778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BitArray stuffBits(BitArray bits, int wordSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wordSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stuffBits_Internal_Static_BitArray_BitArray_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static int TotalBitsInLayer(int layers, bool compact)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&layers);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &compact;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TotalBitsInLayer_Private_Static_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Encoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
