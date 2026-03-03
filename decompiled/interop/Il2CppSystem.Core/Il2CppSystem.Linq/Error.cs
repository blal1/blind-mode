using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq;

public static class Error : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ArgumentNull_Internal_Static_Exception_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_Exception_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoreThanOneMatch_Internal_Static_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NoElements_Internal_Static_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NoMatch_Internal_Static_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotSupported_Internal_Static_Exception_0;

	static Error()
	{
		Il2CppClassPointerStore<Error>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "Error");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Error>.NativeClassPtr);
		NativeMethodInfoPtr_ArgumentNull_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_MoreThanOneMatch_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_NoElements_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_NoMatch_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_NotSupported_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663349);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 859466, RefRangeEnd = 859475, XrefRangeStart = 859462, XrefRangeEnd = 859466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception ArgumentNull(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArgumentNull_Internal_Static_Exception_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859475, XrefRangeEnd = 859479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception ArgumentOutOfRange(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_Exception_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859479, XrefRangeEnd = 859485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception MoreThanOneMatch()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoreThanOneMatch_Internal_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859485, XrefRangeEnd = 859491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception NoElements()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NoElements_Internal_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859491, XrefRangeEnd = 859497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception NoMatch()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NoMatch_Internal_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 859501, RefRangeEnd = 859507, XrefRangeStart = 859497, XrefRangeEnd = 859501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception NotSupported()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotSupported_Internal_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	public Error(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
