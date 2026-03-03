using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.IO;

public static class Directory : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_EnumerationOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalEnumeratePaths_Internal_Static_IEnumerable_1_String_String_String_SearchTarget_EnumerationOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetDirectoryRoot_Internal_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Move_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsecureGetCurrentDirectory_Internal_Static_String_0;

	static Directory()
	{
		Il2CppClassPointerStore<Directory>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Directory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Directory>.NativeClassPtr);
		NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100674696);
		NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100674697);
		NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100674698);
		NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100674699);
		NativeMethodInfoPtr_InternalEnumeratePaths_Internal_Static_IEnumerable_1_String_String_String_SearchTarget_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100674700);
		NativeMethodInfoPtr_InternalGetDirectoryRoot_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100674701);
		NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100674702);
		NativeMethodInfoPtr_Move_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100674703);
		NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100674704);
		NativeMethodInfoPtr_InsecureGetCurrentDirectory_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100674705);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 835719, RefRangeEnd = 835730, XrefRangeStart = 835710, XrefRangeEnd = 835719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DirectoryInfo CreateDirectory(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr2) : null;
	}

	[CallerCount(49)]
	[CachedScanResults(RefRangeStart = 835738, RefRangeEnd = 835787, XrefRangeStart = 835730, XrefRangeEnd = 835738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Exists(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 835798, RefRangeEnd = 835800, XrefRangeStart = 835787, XrefRangeEnd = 835798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetFiles(string path, string searchPattern)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835800, XrefRangeEnd = 835804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enumerationOptions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_EnumerationOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 835811, RefRangeEnd = 835813, XrefRangeStart = 835804, XrefRangeEnd = 835811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
		*(SearchTarget**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &searchTarget;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalEnumeratePaths_Internal_Static_IEnumerable_1_String_String_String_SearchTarget_EnumerationOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 835813, XrefRangeEnd = 835820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InternalGetDirectoryRoot(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalGetDirectoryRoot_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 835821, RefRangeEnd = 835823, XrefRangeStart = 835820, XrefRangeEnd = 835821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCurrentDirectory()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 835851, RefRangeEnd = 835852, XrefRangeStart = 835823, XrefRangeEnd = 835851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Move(string sourceDirName, string destDirName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceDirName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(destDirName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Move_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 835857, RefRangeEnd = 835858, XrefRangeStart = 835852, XrefRangeEnd = 835857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Delete(string path, bool recursive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &recursive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 835862, RefRangeEnd = 835866, XrefRangeStart = 835858, XrefRangeEnd = 835862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InsecureGetCurrentDirectory()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsecureGetCurrentDirectory_Internal_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public Directory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
