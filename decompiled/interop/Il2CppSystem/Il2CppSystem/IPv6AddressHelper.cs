using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

public static class IPv6AddressHelper : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_FindCompressionRange_Internal_Static_ValueTuple_2_Int32_Int32_ReadOnlySpan_1_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldHaveIpv4Embedded_Internal_Static_Boolean_ReadOnlySpan_1_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidStrict_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Internal_Static_Void_ReadOnlySpan_1_Char_ptr_UInt16_Int32_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_byref_Boolean_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLoopback_Private_Static_Boolean_ReadOnlySpan_1_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalIsValid_Private_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0;

	static IPv6AddressHelper()
	{
		Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IPv6AddressHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr);
		NativeMethodInfoPtr_FindCompressionRange_Internal_Static_ValueTuple_2_Int32_Int32_ReadOnlySpan_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664140);
		NativeMethodInfoPtr_ShouldHaveIpv4Embedded_Internal_Static_Boolean_ReadOnlySpan_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664141);
		NativeMethodInfoPtr_IsValidStrict_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664142);
		NativeMethodInfoPtr_Parse_Internal_Static_Void_ReadOnlySpan_1_Char_ptr_UInt16_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664143);
		NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_byref_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664144);
		NativeMethodInfoPtr_IsLoopback_Private_Static_Boolean_ReadOnlySpan_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664145);
		NativeMethodInfoPtr_InternalIsValid_Private_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664146);
		NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPv6AddressHelper>.NativeClassPtr, 100664147);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 868964, RefRangeEnd = 868967, XrefRangeStart = 868958, XrefRangeEnd = 868964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ValueTuple<int, int> FindCompressionRange(ReadOnlySpan<ushort> numbers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)numbers));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindCompressionRange_Internal_Static_ValueTuple_2_Int32_Int32_ReadOnlySpan_1_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ValueTuple<int, int>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 868967, RefRangeEnd = 868968, XrefRangeStart = 868967, XrefRangeEnd = 868967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShouldHaveIpv4Embedded(ReadOnlySpan<ushort> numbers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)numbers));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldHaveIpv4Embedded_Internal_Static_Boolean_ReadOnlySpan_1_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 868984, RefRangeEnd = 868985, XrefRangeStart = 868968, XrefRangeEnd = 868984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValidStrict(char* name, int start, ref int end)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)name;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref end);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidStrict_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 869002, RefRangeEnd = 869003, XrefRangeStart = 868985, XrefRangeEnd = 869002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Parse(ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)address));
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = numbers;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(scopeId);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Internal_Static_Void_ReadOnlySpan_1_Char_ptr_UInt16_Int32_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		scopeId = IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869003, XrefRangeEnd = 869063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isLoopback);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(scopeId);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_byref_Boolean_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		scopeId = IL2CPP.Il2CppStringToManaged(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr3);
	}

	[CallerCount(0)]
	public unsafe static bool IsLoopback(ReadOnlySpan<ushort> numbers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)numbers));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLoopback_Private_Static_Boolean_ReadOnlySpan_1_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 869075, RefRangeEnd = 869076, XrefRangeStart = 869063, XrefRangeEnd = 869075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)name;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref end);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &validateStrictAddress;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalIsValid_Private_Static_Boolean_ptr_Char_Int32_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 869077, RefRangeEnd = 869078, XrefRangeStart = 869076, XrefRangeEnd = 869077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValid(char* name, int start, ref int end)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)name;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref end);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public IPv6AddressHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
