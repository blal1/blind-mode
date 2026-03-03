using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization;

public static class CharUnicodeInfo : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetCategoryValue_Internal_Static_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCombiningCategory_Internal_Static_Boolean_UnicodeCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CategoryLevel1Index_Private_Static_get_ReadOnlySpan_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CategoryLevel2Index_Private_Static_get_ReadOnlySpan_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CategoryLevel3Index_Private_Static_get_ReadOnlySpan_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CategoriesValue_Private_Static_get_ReadOnlySpan_1_Byte_0;

	public unsafe static ReadOnlySpan<byte> CategoryLevel1Index
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 815356, XrefRangeEnd = 815359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CategoryLevel1Index_Private_Static_get_ReadOnlySpan_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlySpan<byte>(pointer);
		}
	}

	public unsafe static ReadOnlySpan<byte> CategoryLevel2Index
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 815359, XrefRangeEnd = 815362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CategoryLevel2Index_Private_Static_get_ReadOnlySpan_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlySpan<byte>(pointer);
		}
	}

	public unsafe static ReadOnlySpan<byte> CategoryLevel3Index
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 815362, XrefRangeEnd = 815365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CategoryLevel3Index_Private_Static_get_ReadOnlySpan_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlySpan<byte>(pointer);
		}
	}

	public unsafe static ReadOnlySpan<byte> CategoriesValue
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 815365, XrefRangeEnd = 815368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CategoriesValue_Private_Static_get_ReadOnlySpan_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlySpan<byte>(pointer);
		}
	}

	static CharUnicodeInfo()
	{
		Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CharUnicodeInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr);
		NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672597);
		NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672598);
		NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672599);
		NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672600);
		NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672601);
		NativeMethodInfoPtr_InternalGetCategoryValue_Internal_Static_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672602);
		NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672603);
		NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672604);
		NativeMethodInfoPtr_IsCombiningCategory_Internal_Static_Boolean_UnicodeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672605);
		NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672606);
		NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672607);
		NativeMethodInfoPtr_get_CategoryLevel1Index_Private_Static_get_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672608);
		NativeMethodInfoPtr_get_CategoryLevel2Index_Private_Static_get_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672609);
		NativeMethodInfoPtr_get_CategoryLevel3Index_Private_Static_get_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672610);
		NativeMethodInfoPtr_get_CategoriesValue_Private_Static_get_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharUnicodeInfo>.NativeClassPtr, 100672611);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 815248, XrefRangeEnd = 815250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int InternalConvertToUtf32(string s, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 815250, XrefRangeEnd = 815252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int InternalConvertToUtf32(string s, int index, out int charLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charLength);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalConvertToUtf32_Internal_Static_Int32_String_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 815253, RefRangeEnd = 815264, XrefRangeStart = 815252, XrefRangeEnd = 815253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnicodeCategory GetUnicodeCategory(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnicodeCategory*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 815281, RefRangeEnd = 815282, XrefRangeStart = 815264, XrefRangeEnd = 815281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnicodeCategory GetUnicodeCategory(string s, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnicodeCategory*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 815296, RefRangeEnd = 815303, XrefRangeStart = 815282, XrefRangeEnd = 815296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnicodeCategory GetUnicodeCategory(int codePoint)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&codePoint);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnicodeCategory*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 815303, XrefRangeEnd = 815317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte InternalGetCategoryValue(int ch, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ch);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetCategoryValue_Internal_Static_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 815323, RefRangeEnd = 815324, XrefRangeStart = 815317, XrefRangeEnd = 815323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnicodeCategory InternalGetUnicodeCategory(string value, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnicodeCategory*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 815330, RefRangeEnd = 815342, XrefRangeStart = 815324, XrefRangeEnd = 815330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charLength);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetUnicodeCategory_Internal_Static_UnicodeCategory_String_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnicodeCategory*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 815342, RefRangeEnd = 815348, XrefRangeStart = 815342, XrefRangeEnd = 815342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsCombiningCategory(UnicodeCategory uc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCombiningCategory_Internal_Static_Boolean_UnicodeCategory_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 815353, RefRangeEnd = 815354, XrefRangeStart = 815348, XrefRangeEnd = 815353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWhiteSpace(string s, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 815355, RefRangeEnd = 815356, XrefRangeStart = 815354, XrefRangeEnd = 815355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWhiteSpace(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWhiteSpace_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public CharUnicodeInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
