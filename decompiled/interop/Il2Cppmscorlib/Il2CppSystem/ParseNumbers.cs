using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

public static class ParseNumbers : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_StringToLong_Public_Static_Int64_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToInt_Public_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToInt_Public_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_Int32_Int32_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LongToString_Public_Static_String_Int64_Int32_Int32_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EatWhiteSpace_Private_Static_Void_ReadOnlySpan_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GrabLongs_Private_Static_Int64_Int32_ReadOnlySpan_1_Char_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GrabInts_Private_Static_Int32_Int32_ReadOnlySpan_1_Char_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowOverflowInt32Exception_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowOverflowInt64Exception_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowOverflowUInt32Exception_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowOverflowUInt64Exception_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDigit_Private_Static_Boolean_Char_Int32_byref_Int32_0;

	static ParseNumbers()
	{
		Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParseNumbers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr);
		NativeMethodInfoPtr_StringToLong_Public_Static_Int64_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665597);
		NativeMethodInfoPtr_StringToInt_Public_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665598);
		NativeMethodInfoPtr_StringToInt_Public_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665599);
		NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_Int32_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665600);
		NativeMethodInfoPtr_LongToString_Public_Static_String_Int64_Int32_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665601);
		NativeMethodInfoPtr_EatWhiteSpace_Private_Static_Void_ReadOnlySpan_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665602);
		NativeMethodInfoPtr_GrabLongs_Private_Static_Int64_Int32_ReadOnlySpan_1_Char_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665603);
		NativeMethodInfoPtr_GrabInts_Private_Static_Int32_Int32_ReadOnlySpan_1_Char_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665604);
		NativeMethodInfoPtr_ThrowOverflowInt32Exception_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665605);
		NativeMethodInfoPtr_ThrowOverflowInt64Exception_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665606);
		NativeMethodInfoPtr_ThrowOverflowUInt32Exception_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665607);
		NativeMethodInfoPtr_ThrowOverflowUInt64Exception_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665608);
		NativeMethodInfoPtr_IsDigit_Private_Static_Boolean_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100665609);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 736080, RefRangeEnd = 736081, XrefRangeStart = 736072, XrefRangeEnd = 736080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long StringToLong(ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radix;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref currPos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToLong_Public_Static_Int64_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 736082, RefRangeEnd = 736083, XrefRangeStart = 736081, XrefRangeEnd = 736082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int StringToInt(ReadOnlySpan<char> s, int radix, int flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radix;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToInt_Public_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 736092, RefRangeEnd = 736094, XrefRangeStart = 736083, XrefRangeEnd = 736092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int StringToInt(ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radix;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref currPos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToInt_Public_Static_Int32_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 736110, RefRangeEnd = 736113, XrefRangeStart = 736094, XrefRangeEnd = 736110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string IntToString(int n, int radix, int width, char paddingChar, int flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&n);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radix;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(char**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &paddingChar;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_Int32_Int32_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 736131, RefRangeEnd = 736132, XrefRangeStart = 736113, XrefRangeEnd = 736131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string LongToString(long n, int radix, int width, char paddingChar, int flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&n);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radix;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(char**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &paddingChar;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LongToString_Public_Static_String_Int64_Int32_Int32_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736132, XrefRangeEnd = 736136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EatWhiteSpace(ReadOnlySpan<char> s, ref int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EatWhiteSpace_Private_Static_Void_ReadOnlySpan_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 736144, RefRangeEnd = 736145, XrefRangeStart = 736136, XrefRangeEnd = 736144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long GrabLongs(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&radix);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref i);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isUnsigned;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GrabLongs_Private_Static_Int64_Int32_ReadOnlySpan_1_Char_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 736153, RefRangeEnd = 736154, XrefRangeStart = 736145, XrefRangeEnd = 736153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GrabInts(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&radix);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)s));
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref i);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isUnsigned;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GrabInts_Private_Static_Int32_Int32_ReadOnlySpan_1_Char_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736154, XrefRangeEnd = 736160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowOverflowInt32Exception()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowOverflowInt32Exception_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736160, XrefRangeEnd = 736166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowOverflowInt64Exception()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowOverflowInt64Exception_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736166, XrefRangeEnd = 736172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowOverflowUInt32Exception()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowOverflowUInt32Exception_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 736172, XrefRangeEnd = 736178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowOverflowUInt64Exception()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowOverflowUInt64Exception_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool IsDigit(char c, int radix, out int result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&c);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radix;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDigit_Private_Static_Boolean_Char_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ParseNumbers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
