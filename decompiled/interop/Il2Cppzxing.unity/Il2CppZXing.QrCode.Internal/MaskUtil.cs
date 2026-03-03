using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppZXing.QrCode.Internal;

public static class MaskUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_applyMaskPenaltyRule1_Public_Static_Int32_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyMaskPenaltyRule2_Public_Static_Int32_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyMaskPenaltyRule3_Public_Static_Int32_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isWhiteHorizontal_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isWhiteVertical_Private_Static_Boolean_Il2CppReferenceArray_1_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyMaskPenaltyRule4_Public_Static_Int32_ByteMatrix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getDataMaskBit_Public_Static_Boolean_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyMaskPenaltyRule1Internal_Private_Static_Int32_ByteMatrix_Boolean_0;

	static MaskUtil()
	{
		Il2CppClassPointerStore<MaskUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.QrCode.Internal", "MaskUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskUtil>.NativeClassPtr);
		NativeMethodInfoPtr_applyMaskPenaltyRule1_Public_Static_Int32_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtil>.NativeClassPtr, 100663731);
		NativeMethodInfoPtr_applyMaskPenaltyRule2_Public_Static_Int32_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtil>.NativeClassPtr, 100663732);
		NativeMethodInfoPtr_applyMaskPenaltyRule3_Public_Static_Int32_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtil>.NativeClassPtr, 100663733);
		NativeMethodInfoPtr_isWhiteHorizontal_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtil>.NativeClassPtr, 100663734);
		NativeMethodInfoPtr_isWhiteVertical_Private_Static_Boolean_Il2CppReferenceArray_1_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtil>.NativeClassPtr, 100663735);
		NativeMethodInfoPtr_applyMaskPenaltyRule4_Public_Static_Int32_ByteMatrix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtil>.NativeClassPtr, 100663736);
		NativeMethodInfoPtr_getDataMaskBit_Public_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtil>.NativeClassPtr, 100663737);
		NativeMethodInfoPtr_applyMaskPenaltyRule1Internal_Private_Static_Int32_ByteMatrix_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskUtil>.NativeClassPtr, 100663738);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417468, RefRangeEnd = 1417469, XrefRangeStart = 1417466, XrefRangeEnd = 1417468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int applyMaskPenaltyRule1(ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyMaskPenaltyRule1_Public_Static_Int32_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int applyMaskPenaltyRule2(ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyMaskPenaltyRule2_Public_Static_Int32_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417473, RefRangeEnd = 1417474, XrefRangeStart = 1417469, XrefRangeEnd = 1417473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int applyMaskPenaltyRule3(ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyMaskPenaltyRule3_Public_Static_Int32_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1417479, RefRangeEnd = 1417481, XrefRangeStart = 1417474, XrefRangeEnd = 1417479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isWhiteHorizontal(Il2CppStructArray<byte> rowArray, int from, int to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rowArray);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isWhiteHorizontal_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1417486, RefRangeEnd = 1417488, XrefRangeStart = 1417481, XrefRangeEnd = 1417486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isWhiteVertical(Il2CppReferenceArray<Il2CppStructArray<byte>> array, int col, int from, int to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &from;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isWhiteVertical_Private_Static_Boolean_Il2CppReferenceArray_1_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417488, XrefRangeEnd = 1417491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int applyMaskPenaltyRule4(ByteMatrix matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyMaskPenaltyRule4_Public_Static_Int32_ByteMatrix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1417491, RefRangeEnd = 1417492, XrefRangeStart = 1417491, XrefRangeEnd = 1417491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool getDataMaskBit(int maskPattern, int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&maskPattern);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDataMaskBit_Public_Static_Boolean_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417492, XrefRangeEnd = 1417495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int applyMaskPenaltyRule1Internal(ByteMatrix matrix, bool isHorizontal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matrix);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isHorizontal;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyMaskPenaltyRule1Internal_Private_Static_Int32_ByteMatrix_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public MaskUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
