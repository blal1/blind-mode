using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppZXing.Datamatrix.Encoder;

public static class HighLevelEncoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_randomize253State_Private_Static_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_encodeHighLevel_Public_Static_String_String_SymbolShapeHint_Dimension_Dimension_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lookAheadTest_Internal_Static_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findMinimums_Private_Static_Int32_Il2CppStructArray_1_Single_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMinimumCount_Private_Static_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isDigit_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isExtendedASCII_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isNativeC40_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isNativeText_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isNativeX12_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isX12TermSep_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isNativeEDIFACT_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isSpecialB256_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_determineConsecutiveDigitCount_Public_Static_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_illegalCharacter_Internal_Static_Void_Char_0;

	static HighLevelEncoder()
	{
		Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Datamatrix.Encoder", "HighLevelEncoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr);
		NativeMethodInfoPtr_randomize253State_Private_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664536);
		NativeMethodInfoPtr_encodeHighLevel_Public_Static_String_String_SymbolShapeHint_Dimension_Dimension_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664537);
		NativeMethodInfoPtr_lookAheadTest_Internal_Static_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664538);
		NativeMethodInfoPtr_findMinimums_Private_Static_Int32_Il2CppStructArray_1_Single_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664539);
		NativeMethodInfoPtr_getMinimumCount_Private_Static_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664540);
		NativeMethodInfoPtr_isDigit_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664541);
		NativeMethodInfoPtr_isExtendedASCII_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664542);
		NativeMethodInfoPtr_isNativeC40_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664543);
		NativeMethodInfoPtr_isNativeText_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664544);
		NativeMethodInfoPtr_isNativeX12_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664545);
		NativeMethodInfoPtr_isX12TermSep_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664546);
		NativeMethodInfoPtr_isNativeEDIFACT_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664547);
		NativeMethodInfoPtr_isSpecialB256_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664548);
		NativeMethodInfoPtr_determineConsecutiveDigitCount_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664549);
		NativeMethodInfoPtr_illegalCharacter_Internal_Static_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664550);
	}

	[CallerCount(0)]
	public unsafe static char randomize253State(int codewordPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&codewordPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_randomize253State_Private_Static_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1426868, RefRangeEnd = 1426869, XrefRangeStart = 1426787, XrefRangeEnd = 1426868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string encodeHighLevel(string msg, SymbolShapeHint shape, Dimension minSize, Dimension maxSize, int defaultEncodation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(SymbolShapeHint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shape;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)minSize);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)maxSize);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultEncodation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encodeHighLevel_Public_Static_String_String_SymbolShapeHint_Dimension_Dimension_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1426913, RefRangeEnd = 1426918, XrefRangeStart = 1426869, XrefRangeEnd = 1426913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int lookAheadTest(string msg, int startpos, int currentMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startpos;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lookAheadTest_Internal_Static_Int32_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426918, XrefRangeEnd = 1426929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int findMinimums(Il2CppStructArray<float> charCounts, Il2CppStructArray<int> intCharCounts, int min, Il2CppStructArray<byte> mins)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charCounts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)intCharCounts);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mins);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findMinimums_Private_Static_Int32_Il2CppStructArray_1_Single_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int getMinimumCount(Il2CppStructArray<byte> mins)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mins);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMinimumCount_Private_Static_Int32_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool isDigit(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isDigit_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool isExtendedASCII(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isExtendedASCII_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool isNativeC40(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isNativeC40_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool isNativeText(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isNativeText_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool isNativeX12(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isNativeX12_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool isX12TermSep(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isX12TermSep_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool isNativeEDIFACT(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isNativeEDIFACT_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isSpecialB256(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isSpecialB256_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426929, XrefRangeEnd = 1426931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int determineConsecutiveDigitCount(string msg, int startpos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startpos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determineConsecutiveDigitCount_Public_Static_Int32_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1426942, RefRangeEnd = 1426944, XrefRangeStart = 1426931, XrefRangeEnd = 1426942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void illegalCharacter(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_illegalCharacter_Internal_Static_Void_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HighLevelEncoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
