using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO;

public static class File : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_OpenText_Public_Static_StreamReader_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_FileAccess_FileShare_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenRead_Public_Static_FileStream_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenWrite_Public_Static_FileStream_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalReadAllText_Private_Static_String_String_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadAllBytesUnknownLength_Private_Static_Il2CppStructArray_1_Byte_FileStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalWriteAllBytes_Private_Static_Void_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Move_Public_Static_Void_String_String_0;

	static File()
	{
		Il2CppClassPointerStore<File>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "File");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<File>.NativeClassPtr);
		NativeMethodInfoPtr_OpenText_Public_Static_StreamReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674739);
		NativeMethodInfoPtr_Delete_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674740);
		NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674741);
		NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674742);
		NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_FileAccess_FileShare_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674743);
		NativeMethodInfoPtr_OpenRead_Public_Static_FileStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674744);
		NativeMethodInfoPtr_OpenWrite_Public_Static_FileStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674745);
		NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674746);
		NativeMethodInfoPtr_InternalReadAllText_Private_Static_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674747);
		NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674748);
		NativeMethodInfoPtr_ReadAllBytesUnknownLength_Private_Static_Il2CppStructArray_1_Byte_FileStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674749);
		NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674750);
		NativeMethodInfoPtr_InternalWriteAllBytes_Private_Static_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674751);
		NativeMethodInfoPtr_Move_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<File>.NativeClassPtr, 100674752);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 836115, RefRangeEnd = 836116, XrefRangeStart = 836110, XrefRangeEnd = 836115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StreamReader OpenText(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenText_Public_Static_StreamReader_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 836127, RefRangeEnd = 836130, XrefRangeStart = 836116, XrefRangeEnd = 836127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Delete(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Delete_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 836143, RefRangeEnd = 836161, XrefRangeStart = 836130, XrefRangeEnd = 836143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Exists(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 836165, RefRangeEnd = 836166, XrefRangeStart = 836161, XrefRangeEnd = 836165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FileStream Open(string path, FileMode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(FileMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FileStream>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836166, XrefRangeEnd = 836170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(FileMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		*(FileAccess**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &access;
		*(FileShare**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &share;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Open_Public_Static_FileStream_String_FileMode_FileAccess_FileShare_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FileStream>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 836174, RefRangeEnd = 836178, XrefRangeStart = 836170, XrefRangeEnd = 836174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FileStream OpenRead(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenRead_Public_Static_FileStream_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FileStream>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 836182, RefRangeEnd = 836183, XrefRangeStart = 836178, XrefRangeEnd = 836182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FileStream OpenWrite(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenWrite_Public_Static_FileStream_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FileStream>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 836198, RefRangeEnd = 836199, XrefRangeStart = 836183, XrefRangeEnd = 836198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReadAllText(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadAllText_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 836209, RefRangeEnd = 836210, XrefRangeStart = 836199, XrefRangeEnd = 836209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InternalReadAllText(string path, Encoding encoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalReadAllText_Private_Static_String_String_Encoding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 836228, RefRangeEnd = 836230, XrefRangeStart = 836210, XrefRangeEnd = 836228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> ReadAllBytes(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 836285, RefRangeEnd = 836286, XrefRangeStart = 836230, XrefRangeEnd = 836285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> ReadAllBytesUnknownLength(FileStream fs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadAllBytesUnknownLength_Private_Static_Il2CppStructArray_1_Byte_FileStream_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 836307, RefRangeEnd = 836309, XrefRangeStart = 836286, XrefRangeEnd = 836307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteAllBytes(string path, Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 836319, RefRangeEnd = 836320, XrefRangeStart = 836309, XrefRangeEnd = 836319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalWriteAllBytes(string path, Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalWriteAllBytes_Private_Static_Void_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 836327, RefRangeEnd = 836328, XrefRangeStart = 836320, XrefRangeEnd = 836327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Move(string sourceFileName, string destFileName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceFileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(destFileName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Move_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public File(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
