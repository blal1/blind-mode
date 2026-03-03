using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO;

public static class Error : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetStreamIsClosed_Internal_Static_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEndOfFile_Internal_Static_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReadNotSupported_Internal_Static_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWriteNotSupported_Internal_Static_Exception_0;

	static Error()
	{
		Il2CppClassPointerStore<Error>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Error");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Error>.NativeClassPtr);
		NativeMethodInfoPtr_GetStreamIsClosed_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100674432);
		NativeMethodInfoPtr_GetEndOfFile_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100674433);
		NativeMethodInfoPtr_GetReadNotSupported_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100674434);
		NativeMethodInfoPtr_GetWriteNotSupported_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100674435);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 834032, RefRangeEnd = 834036, XrefRangeStart = 834026, XrefRangeEnd = 834032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception GetStreamIsClosed()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStreamIsClosed_Internal_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 834036, XrefRangeEnd = 834042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception GetEndOfFile()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEndOfFile_Internal_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 834048, RefRangeEnd = 834049, XrefRangeStart = 834042, XrefRangeEnd = 834048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception GetReadNotSupported()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReadNotSupported_Internal_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 834055, RefRangeEnd = 834056, XrefRangeStart = 834049, XrefRangeEnd = 834055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception GetWriteNotSupported()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWriteNotSupported_Internal_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	public Error(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
