using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Assertions;

public class AssertionMessageUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEqualityMessage_Public_Static_String_Object_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NullFailureMessage_Public_Static_String_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0;

	public const string k_Expected = "Expected:";

	public const string k_AssertionFailed = "Assertion failure.";

	static AssertionMessageUtil()
	{
		Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Assertions", "AssertionMessageUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr);
		NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100667620);
		NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100667621);
		NativeMethodInfoPtr_GetEqualityMessage_Public_Static_String_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100667622);
		NativeMethodInfoPtr_NullFailureMessage_Public_Static_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100667623);
		NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100667624);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231426, XrefRangeEnd = 1231445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetMessage(string failureMessage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(failureMessage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1231490, RefRangeEnd = 1231497, XrefRangeStart = 1231445, XrefRangeEnd = 1231490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetMessage(string failureMessage, string expected)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(failureMessage);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(expected);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1231535, RefRangeEnd = 1231537, XrefRangeStart = 1231497, XrefRangeEnd = 1231535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetEqualityMessage(Il2CppSystem.Object actual, Il2CppSystem.Object expected, bool expectEqual)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actual);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)expected);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &expectEqual;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEqualityMessage_Public_Static_String_Object_Object_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1231564, RefRangeEnd = 1231570, XrefRangeStart = 1231537, XrefRangeEnd = 1231564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string NullFailureMessage(Il2CppSystem.Object value, bool expectNull)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &expectNull;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NullFailureMessage_Public_Static_String_Object_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231570, XrefRangeEnd = 1231578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string BooleanFailureMessage(bool expected)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&expected);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public AssertionMessageUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
