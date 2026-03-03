using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

public static class FixedBufferExtensions : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetStringFromFixedBuffer_Internal_Static_String_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFixedBufferStringLength_Internal_Static_Int32_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedBufferEqualsString_Internal_Static_Boolean_ReadOnlySpan_1_Char_String_0;

	static FixedBufferExtensions()
	{
		Il2CppClassPointerStore<FixedBufferExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "FixedBufferExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedBufferExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_GetStringFromFixedBuffer_Internal_Static_String_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferExtensions>.NativeClassPtr, 100666289);
		NativeMethodInfoPtr_GetFixedBufferStringLength_Internal_Static_Int32_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferExtensions>.NativeClassPtr, 100666290);
		NativeMethodInfoPtr_FixedBufferEqualsString_Internal_Static_Boolean_ReadOnlySpan_1_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedBufferExtensions>.NativeClassPtr, 100666291);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 748915, RefRangeEnd = 748917, XrefRangeStart = 748907, XrefRangeEnd = 748915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetStringFromFixedBuffer(this ReadOnlySpan<char> span)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)span));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStringFromFixedBuffer_Internal_Static_String_ReadOnlySpan_1_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748917, XrefRangeEnd = 748921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetFixedBufferStringLength(this ReadOnlySpan<char> span)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)span));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFixedBufferStringLength_Internal_Static_Int32_ReadOnlySpan_1_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 748927, RefRangeEnd = 748929, XrefRangeStart = 748921, XrefRangeEnd = 748927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FixedBufferEqualsString(this ReadOnlySpan<char> span, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)span));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedBufferEqualsString_Internal_Static_Boolean_ReadOnlySpan_1_Char_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public FixedBufferExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
