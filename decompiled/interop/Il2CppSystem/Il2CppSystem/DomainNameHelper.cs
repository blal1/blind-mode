using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

public class DomainNameHelper : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidByIri_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_ptr_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_String_ptr_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsASCIILetterOrDigit_Private_Static_Boolean_Char_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidDomainLabelCharacter_Private_Static_Boolean_Char_byref_Boolean_0;

	static DomainNameHelper()
	{
		Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "DomainNameHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr);
		NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664332);
		NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664333);
		NativeMethodInfoPtr_IsValidByIri_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664334);
		NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664335);
		NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664336);
		NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664337);
		NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664338);
		NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664339);
		NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664340);
		NativeMethodInfoPtr_IsASCIILetterOrDigit_Private_Static_Boolean_Char_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664341);
		NativeMethodInfoPtr_IsValidDomainLabelCharacter_Private_Static_Boolean_Char_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664342);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871627, RefRangeEnd = 871628, XrefRangeStart = 871610, XrefRangeEnd = 871627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ParseCanonicalName(string str, int start, int end, ref bool loopback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref loopback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871629, RefRangeEnd = 871630, XrefRangeStart = 871628, XrefRangeEnd = 871629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)name;
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref returnedEnd);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref notCanonical);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &notImplicitFile;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871632, RefRangeEnd = 871633, XrefRangeStart = 871630, XrefRangeEnd = 871632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)name;
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref returnedEnd);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref notCanonical);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &notImplicitFile;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidByIri_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871635, RefRangeEnd = 871636, XrefRangeStart = 871633, XrefRangeEnd = 871635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)hostname;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref allAscii);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref atLeastOneValidIdn);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 871650, RefRangeEnd = 871652, XrefRangeStart = 871636, XrefRangeEnd = 871650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)hostname;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref allAscii);
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(bidiStrippedHost);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		bidiStrippedHost = IL2CPP.Il2CppStringToManaged(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871652, XrefRangeEnd = 871656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsIdnAce(string input, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsIdnAce(char* input, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)input;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_ptr_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 871661, RefRangeEnd = 871662, XrefRangeStart = 871656, XrefRangeEnd = 871661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(idnHost);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = hostname;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_String_ptr_Char_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 871699, RefRangeEnd = 871702, XrefRangeStart = 871662, XrefRangeEnd = 871699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)hostname;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref allAscii);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref atLeastOneValidIdn);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsASCIILetterOrDigit(char character, ref bool notCanonical)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&character);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref notCanonical);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsASCIILetterOrDigit_Private_Static_Boolean_Char_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&character);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref notCanonical);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidDomainLabelCharacter_Private_Static_Boolean_Char_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DomainNameHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
