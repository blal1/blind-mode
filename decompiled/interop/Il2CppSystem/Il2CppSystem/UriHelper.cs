using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem;

public static class UriHelper : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_HexUpperChars;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestForSubPath_Internal_Static_Boolean_ptr_Char_UInt16_ptr_Char_UInt16_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EscapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Boolean_Char_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureDestinationSize_Private_Static_Il2CppStructArray_1_Char_ptr_Char_Il2CppStructArray_1_Char_Int32_Int16_Int16_byref_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_ptr_Char_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MatchUTF8Sequence_Internal_Static_Void_ptr_Char_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EscapeAsciiChar_Internal_Static_Void_Char_Il2CppStructArray_1_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EscapedAscii_Internal_Static_Char_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNotSafeForUnescape_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsReservedUnreservedOrHash_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUnreserved_Internal_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Is3986Unreserved_Internal_Static_Boolean_Char_0;

	public unsafe static Il2CppStructArray<char> HexUpperChars
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HexUpperChars, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HexUpperChars, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static UriHelper()
	{
		Il2CppClassPointerStore<UriHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "UriHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UriHelper>.NativeClassPtr);
		NativeFieldInfoPtr_HexUpperChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, "HexUpperChars");
		NativeMethodInfoPtr_TestForSubPath_Internal_Static_Boolean_ptr_Char_UInt16_ptr_Char_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664293);
		NativeMethodInfoPtr_EscapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Boolean_Char_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664294);
		NativeMethodInfoPtr_EnsureDestinationSize_Private_Static_Il2CppStructArray_1_Char_ptr_Char_Il2CppStructArray_1_Char_Int32_Int16_Int16_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664295);
		NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664296);
		NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_ptr_Char_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664297);
		NativeMethodInfoPtr_MatchUTF8Sequence_Internal_Static_Void_ptr_Char_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664298);
		NativeMethodInfoPtr_EscapeAsciiChar_Internal_Static_Void_Char_Il2CppStructArray_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664299);
		NativeMethodInfoPtr_EscapedAscii_Internal_Static_Char_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664300);
		NativeMethodInfoPtr_IsNotSafeForUnescape_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664301);
		NativeMethodInfoPtr_IsReservedUnreservedOrHash_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664302);
		NativeMethodInfoPtr_IsUnreserved_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664303);
		NativeMethodInfoPtr_Is3986Unreserved_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriHelper>.NativeClassPtr, 100664304);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871151, RefRangeEnd = 871152, XrefRangeStart = 871140, XrefRangeEnd = 871151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TestForSubPath(char* pMe, ushort meLength, char* pShe, ushort sheLength, bool ignoreCase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)pMe;
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &meLength;
		*(char**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = pShe;
		*(ushort**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sheLength;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreCase;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestForSubPath_Internal_Static_Boolean_ptr_Char_UInt16_ptr_Char_UInt16_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 871195, RefRangeEnd = 871201, XrefRangeStart = 871152, XrefRangeEnd = 871195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<char> EscapeString(string input, int start, int end, Il2CppStructArray<char> dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destPos);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &isUriString;
		*(char**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &force1;
		*(char**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &force2;
		*(char**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &rsvd;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EscapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Boolean_Char_Char_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 871205, RefRangeEnd = 871208, XrefRangeStart = 871201, XrefRangeEnd = 871205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<char> EnsureDestinationSize(char* pStr, Il2CppStructArray<char> dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)pStr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentInputPos;
		*(short**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &charsToAdd;
		*(short**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &minReallocateChars;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destPos);
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &prevInputPos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureDestinationSize_Private_Static_Il2CppStructArray_1_Char_ptr_Char_Il2CppStructArray_1_Char_Int32_Int16_Int16_byref_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 871213, RefRangeEnd = 871220, XrefRangeStart = 871208, XrefRangeEnd = 871213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<char> UnescapeString(string input, int start, int end, Il2CppStructArray<char> dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destPosition);
		*(char**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &rsvd1;
		*(char**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &rsvd2;
		*(char**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &rsvd3;
		*(UnescapeMode**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &unescapeMode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syntax);
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &isQuery;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_String_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871292, RefRangeEnd = 871293, XrefRangeStart = 871220, XrefRangeEnd = 871292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<char> UnescapeString(char* pStr, int start, int end, Il2CppStructArray<char> dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = (nint)pStr;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destPosition);
		*(char**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &rsvd1;
		*(char**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &rsvd2;
		*(char**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &rsvd3;
		*(UnescapeMode**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &unescapeMode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)syntax);
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &isQuery;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnescapeString_Internal_Static_Il2CppStructArray_1_Char_ptr_Char_Int32_Int32_Il2CppStructArray_1_Char_byref_Int32_Char_Char_Char_UnescapeMode_UriParser_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 871325, RefRangeEnd = 871327, XrefRangeStart = 871293, XrefRangeEnd = 871325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MatchUTF8Sequence(char* pDest, Il2CppStructArray<char> dest, ref int destOffset, Il2CppStructArray<char> unescapedChars, int charCount, Il2CppStructArray<byte> bytes, int byteCount, bool isQuery, bool iriParsing)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)pDest;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref destOffset);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unescapedChars);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &charCount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &byteCount;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &isQuery;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &iriParsing;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MatchUTF8Sequence_Internal_Static_Void_ptr_Char_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 871332, RefRangeEnd = 871340, XrefRangeStart = 871327, XrefRangeEnd = 871332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EscapeAsciiChar(char ch, Il2CppStructArray<char> to, ref int pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ch);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)to);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EscapeAsciiChar_Internal_Static_Void_Char_Il2CppStructArray_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 871341, RefRangeEnd = 871350, XrefRangeStart = 871340, XrefRangeEnd = 871341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char EscapedAscii(char digit, char next)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&digit);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &next;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EscapedAscii_Internal_Static_Char_Char_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 871350, RefRangeEnd = 871353, XrefRangeStart = 871350, XrefRangeEnd = 871350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsNotSafeForUnescape(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNotSafeForUnescape_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871368, RefRangeEnd = 871369, XrefRangeStart = 871353, XrefRangeEnd = 871368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsReservedUnreservedOrHash(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsReservedUnreservedOrHash_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 871384, RefRangeEnd = 871386, XrefRangeStart = 871369, XrefRangeEnd = 871384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsUnreserved(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUnreserved_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871393, RefRangeEnd = 871394, XrefRangeStart = 871386, XrefRangeEnd = 871393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Is3986Unreserved(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Is3986Unreserved_Internal_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public UriHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
