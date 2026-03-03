using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net;

public class IPAddressParser : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Internal_Static_IPAddress_ReadOnlySpan_1_Char_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IPv4AddressToString_Internal_Static_String_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IPv4AddressToString_Internal_Static_Void_UInt32_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IPv4AddressToStringHelper_Private_Static_Int32_UInt32_ptr_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IPv6AddressToString_Internal_Static_String_Il2CppStructArray_1_UInt16_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IPv6AddressToStringHelper_Internal_Static_StringBuilder_Il2CppStructArray_1_UInt16_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatIPv4AddressNumber_Private_Static_Void_Int32_ptr_Char_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ipv4StringToAddress_Public_Static_Boolean_ReadOnlySpan_1_Char_byref_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ipv6StringToAddress_Public_Static_Boolean_ReadOnlySpan_1_Char_ptr_UInt16_Int32_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendSections_Private_Static_Void_Il2CppStructArray_1_UInt16_Int32_Int32_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendHex_Private_Static_Void_UInt16_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractIPv4Address_Private_Static_UInt32_Il2CppStructArray_1_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reverse_Private_Static_UInt16_UInt16_0;

	static IPAddressParser()
	{
		Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IPAddressParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr);
		NativeMethodInfoPtr_Parse_Internal_Static_IPAddress_ReadOnlySpan_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100665890);
		NativeMethodInfoPtr_IPv4AddressToString_Internal_Static_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100665891);
		NativeMethodInfoPtr_IPv4AddressToString_Internal_Static_Void_UInt32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100665892);
		NativeMethodInfoPtr_IPv4AddressToStringHelper_Private_Static_Int32_UInt32_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100665893);
		NativeMethodInfoPtr_IPv6AddressToString_Internal_Static_String_Il2CppStructArray_1_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100665894);
		NativeMethodInfoPtr_IPv6AddressToStringHelper_Internal_Static_StringBuilder_Il2CppStructArray_1_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100665895);
		NativeMethodInfoPtr_FormatIPv4AddressNumber_Private_Static_Void_Int32_ptr_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100665896);
		NativeMethodInfoPtr_Ipv4StringToAddress_Public_Static_Boolean_ReadOnlySpan_1_Char_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100665897);
		NativeMethodInfoPtr_Ipv6StringToAddress_Public_Static_Boolean_ReadOnlySpan_1_Char_ptr_UInt16_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100665898);
		NativeMethodInfoPtr_AppendSections_Private_Static_Void_Il2CppStructArray_1_UInt16_Int32_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100665899);
		NativeMethodInfoPtr_AppendHex_Private_Static_Void_UInt16_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100665900);
		NativeMethodInfoPtr_ExtractIPv4Address_Private_Static_UInt32_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100665901);
		NativeMethodInfoPtr_Reverse_Private_Static_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPAddressParser>.NativeClassPtr, 100665902);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 885279, RefRangeEnd = 885281, XrefRangeStart = 885266, XrefRangeEnd = 885279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IPAddress Parse(ReadOnlySpan<char> ipSpan, bool tryParse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ipSpan));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tryParse;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Internal_Static_IPAddress_ReadOnlySpan_1_Char_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 885283, RefRangeEnd = 885284, XrefRangeStart = 885281, XrefRangeEnd = 885283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string IPv4AddressToString(uint address)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&address);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IPv4AddressToString_Internal_Static_String_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 885286, RefRangeEnd = 885287, XrefRangeStart = 885284, XrefRangeEnd = 885286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IPv4AddressToString(uint address, StringBuilder destination)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&address);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IPv4AddressToString_Internal_Static_Void_UInt32_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 885302, RefRangeEnd = 885304, XrefRangeStart = 885287, XrefRangeEnd = 885302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IPv4AddressToStringHelper(uint address, char* addressString)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&address);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = addressString;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IPv4AddressToStringHelper_Private_Static_Int32_UInt32_ptr_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885304, XrefRangeEnd = 885306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string IPv6AddressToString(Il2CppStructArray<ushort> address, uint scopeId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)address);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scopeId;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IPv6AddressToString_Internal_Static_String_Il2CppStructArray_1_UInt16_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 885344, RefRangeEnd = 885346, XrefRangeStart = 885306, XrefRangeEnd = 885344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StringBuilder IPv6AddressToStringHelper(Il2CppStructArray<ushort> address, uint scopeId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)address);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scopeId;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IPv6AddressToStringHelper_Internal_Static_StringBuilder_Il2CppStructArray_1_UInt16_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 885351, RefRangeEnd = 885352, XrefRangeStart = 885346, XrefRangeEnd = 885351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatIPv4AddressNumber(int number, char* addressString, ref int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&number);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = addressString;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref offset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatIPv4AddressNumber_Private_Static_Void_Int32_ptr_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885352, XrefRangeEnd = 885357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Ipv4StringToAddress(ReadOnlySpan<char> ipSpan, out long address)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ipSpan));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref address);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ipv4StringToAddress_Public_Static_Boolean_ReadOnlySpan_1_Char_byref_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885357, XrefRangeEnd = 885362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Ipv6StringToAddress(ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, out uint scope)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ipSpan));
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = numbers;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numbersLength;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref scope);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ipv6StringToAddress_Public_Static_Boolean_ReadOnlySpan_1_Char_ptr_UInt16_Int32_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885362, XrefRangeEnd = 885375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AppendSections(Il2CppStructArray<ushort> address, int fromInclusive, int toExclusive, StringBuilder buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)address);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromInclusive;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toExclusive;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendSections_Private_Static_Void_Il2CppStructArray_1_UInt16_Int32_Int32_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 885376, RefRangeEnd = 885382, XrefRangeStart = 885375, XrefRangeEnd = 885376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AppendHex(ushort value, StringBuilder buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendHex_Private_Static_Void_UInt16_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static uint ExtractIPv4Address(Il2CppStructArray<ushort> address)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)address);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractIPv4Address_Private_Static_UInt32_Il2CppStructArray_1_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static ushort Reverse(ushort number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&number);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reverse_Private_Static_UInt16_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public IPAddressParser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
