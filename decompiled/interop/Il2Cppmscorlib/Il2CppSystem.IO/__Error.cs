using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO;

public static class __Error : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_EndOfFile_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FileNotOpen_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReaderClosed_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayablePath_Internal_Static_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WinIOError_Internal_Static_Void_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriterClosed_Internal_Static_Void_0;

	static __Error()
	{
		Il2CppClassPointerStore<__Error>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "__Error");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Error>.NativeClassPtr);
		NativeMethodInfoPtr_EndOfFile_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100674885);
		NativeMethodInfoPtr_FileNotOpen_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100674886);
		NativeMethodInfoPtr_ReaderClosed_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100674887);
		NativeMethodInfoPtr_GetDisplayablePath_Internal_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100674888);
		NativeMethodInfoPtr_WinIOError_Internal_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100674889);
		NativeMethodInfoPtr_WriterClosed_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Error>.NativeClassPtr, 100674890);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 837209, RefRangeEnd = 837212, XrefRangeStart = 837202, XrefRangeEnd = 837209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndOfFile()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndOfFile_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 837219, RefRangeEnd = 837221, XrefRangeStart = 837212, XrefRangeEnd = 837219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FileNotOpen()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FileNotOpen_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 837221, XrefRangeEnd = 837228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReaderClosed()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReaderClosed_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 837246, RefRangeEnd = 837248, XrefRangeStart = 837228, XrefRangeEnd = 837246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetDisplayablePath(string path, bool isInvalidPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isInvalidPath;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDisplayablePath_Internal_Static_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 837393, RefRangeEnd = 837394, XrefRangeStart = 837248, XrefRangeEnd = 837393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WinIOError(int errorCode, string maybeFullPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&errorCode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(maybeFullPath);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WinIOError_Internal_Static_Void_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 837401, RefRangeEnd = 837403, XrefRangeStart = 837394, XrefRangeEnd = 837401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriterClosed()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriterClosed_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public __Error(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
