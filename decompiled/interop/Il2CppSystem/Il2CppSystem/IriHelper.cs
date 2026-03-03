using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

public static class IriHelper : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Char_byref_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIsReserved_Internal_Static_Boolean_Char_UriComponents_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EscapeUnescapeIri_Internal_Static_String_ptr_Char_Int32_Int32_UriComponents_0;

	static IriHelper()
	{
		Il2CppClassPointerStore<IriHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IriHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IriHelper>.NativeClassPtr);
		NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IriHelper>.NativeClassPtr, 100664157);
		NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Char_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IriHelper>.NativeClassPtr, 100664158);
		NativeMethodInfoPtr_CheckIsReserved_Internal_Static_Boolean_Char_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IriHelper>.NativeClassPtr, 100664159);
		NativeMethodInfoPtr_EscapeUnescapeIri_Internal_Static_String_ptr_Char_Int32_Int32_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IriHelper>.NativeClassPtr, 100664160);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 869260, RefRangeEnd = 869264, XrefRangeStart = 869260, XrefRangeEnd = 869260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckIriUnicodeRange(char unicode, bool isQuery)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&unicode);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isQuery;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 869367, RefRangeEnd = 869370, XrefRangeStart = 869264, XrefRangeEnd = 869367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&highSurr);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lowSurr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref surrogatePair);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isQuery;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Char_byref_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 869374, RefRangeEnd = 869375, XrefRangeStart = 869370, XrefRangeEnd = 869374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckIsReserved(char ch, UriComponents component)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ch);
		*(UriComponents**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &component;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIsReserved_Internal_Static_Boolean_Char_UriComponents_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 869454, RefRangeEnd = 869459, XrefRangeStart = 869375, XrefRangeEnd = 869454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)pInput;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(UriComponents**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &component;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EscapeUnescapeIri_Internal_Static_String_ptr_Char_Int32_Int32_UriComponents_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public IriHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
