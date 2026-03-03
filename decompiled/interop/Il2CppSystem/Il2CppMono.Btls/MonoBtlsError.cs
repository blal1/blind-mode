using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Btls;

public static class MonoBtlsError : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_error_clear_error_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_error_get_error_line_Private_Static_Int32_byref_IntPtr_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_error_get_error_string_n_Private_Static_Void_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_error_get_reason_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearError_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetErrorString_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetError_Public_Static_Int32_byref_String_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetErrorReason_Public_Static_Int32_Int32_0;

	static MonoBtlsError()
	{
		Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsError");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr);
		NativeMethodInfoPtr_mono_btls_error_clear_error_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663742);
		NativeMethodInfoPtr_mono_btls_error_get_error_line_Private_Static_Int32_byref_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663743);
		NativeMethodInfoPtr_mono_btls_error_get_error_string_n_Private_Static_Void_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663744);
		NativeMethodInfoPtr_mono_btls_error_get_reason_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663745);
		NativeMethodInfoPtr_ClearError_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663746);
		NativeMethodInfoPtr_GetErrorString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663747);
		NativeMethodInfoPtr_GetError_Public_Static_Int32_byref_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663748);
		NativeMethodInfoPtr_GetErrorReason_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsError>.NativeClassPtr, 100663749);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 865446, RefRangeEnd = 865448, XrefRangeStart = 865444, XrefRangeEnd = 865446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void mono_btls_error_clear_error()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_error_clear_error_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865448, XrefRangeEnd = 865450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_error_get_error_line(out System.IntPtr file, out int line)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref file);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref line);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_error_get_error_line_Private_Static_Int32_byref_IntPtr_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865450, XrefRangeEnd = 865452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void mono_btls_error_get_error_string_n(int error, System.IntPtr buf, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&error);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buf;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_error_get_error_string_n_Private_Static_Void_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865452, XrefRangeEnd = 865454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_error_get_reason(int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_error_get_reason_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 865446, RefRangeEnd = 865448, XrefRangeStart = 865446, XrefRangeEnd = 865448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearError()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearError_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 865470, RefRangeEnd = 865471, XrefRangeStart = 865454, XrefRangeEnd = 865470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetErrorString(int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetErrorString_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865471, XrefRangeEnd = 865479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetError(out string file, out int line)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		nint num = 0;
		*ptr = (nint)(&num);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref line);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetError_Public_Static_Int32_byref_String_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		file = IL2CPP.Il2CppStringToManaged((System.IntPtr)num);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetErrorReason(int error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetErrorReason_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public MonoBtlsError(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
