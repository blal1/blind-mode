using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem;

namespace Il2CppWin32;

public static class FileApi : Il2CppSystem.Object
{
	[OriginalName("Assembly-CSharp.dll", "", "DesiredAccess")]
	public enum DesiredAccess : uint
	{
		GENERIC_ALL = 0x10000000u,
		GENERIC_EXECUTE = 0x20000000u,
		GENERIC_WRITE = 0x40000000u,
		GENERIC_READ = 0x80000000u
	}

	[OriginalName("Assembly-CSharp.dll", "", "ShareMode")]
	public enum ShareMode : uint
	{
		FILE_SHARE_NONE = 0u,
		FILE_SHARE_READ = 1u,
		FILE_SHARE_WRITE = 2u,
		FILE_SHARE_DELETE = 4u
	}

	[OriginalName("Assembly-CSharp.dll", "", "CreationDisposition")]
	public enum CreationDisposition : uint
	{
		CREATE_NEW = 1u,
		CREATE_ALWAYS,
		OPEN_EXISTING,
		OPEN_ALWAYS,
		TRUNCATE_EXISTING
	}

	[OriginalName("Assembly-CSharp.dll", "", "FlagsAndAttributes")]
	public enum FlagsAndAttributes : uint
	{
		FILE_ATTRIBUTE_READONLY = 1u,
		FILE_ATTRIBUTE_HIDDEN = 2u,
		FILE_ATTRIBUTE_SYSTEM = 4u,
		FILE_ATTRIBUTE_DIRECTORY = 16u,
		FILE_ATTRIBUTE_ARCHIVE = 32u,
		FILE_ATTRIBUTE_DEVICE = 64u,
		FILE_ATTRIBUTE_NORMAL = 128u,
		FILE_ATTRIBUTE_TEMPORARY = 256u,
		FILE_ATTRIBUTE_SPARSE_FILE = 512u,
		FILE_ATTRIBUTE_REPARSE_POINT = 1024u,
		FILE_ATTRIBUTE_COMPRESSED = 2048u,
		FILE_ATTRIBUTE_OFFLINE = 4096u,
		FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 8192u,
		FILE_ATTRIBUTE_ENCRYPTED = 16384u,
		FILE_ATTRIBUTE_VIRTUAL = 65536u,
		FILE_ATTRIBUTE_VALID_FLAGS = 32695u,
		FILE_ATTRIBUTE_VALID_SET_FLAGS = 12711u,
		FILE_FLAG_OVERLAPPED = 1073741824u
	}

	[OriginalName("Assembly-CSharp.dll", "", "SeekOrigin")]
	public enum SeekOrigin : uint
	{
		FILE_BEGIN,
		FILE_CURRENT,
		FILE_END
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct LARGE_INTEGER
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_LowPart;

		private static readonly System.IntPtr NativeFieldInfoPtr_HighPart;

		private static readonly System.IntPtr NativeFieldInfoPtr_QuadPart;

		[FieldOffset(0)]
		public int LowPart;

		[FieldOffset(4)]
		public int HighPart;

		[FieldOffset(0)]
		public long QuadPart;

		static LARGE_INTEGER()
		{
			Il2CppClassPointerStore<LARGE_INTEGER>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileApi>.NativeClassPtr, "LARGE_INTEGER");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LARGE_INTEGER>.NativeClassPtr);
			NativeFieldInfoPtr_LowPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LARGE_INTEGER>.NativeClassPtr, "LowPart");
			NativeFieldInfoPtr_HighPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LARGE_INTEGER>.NativeClassPtr, "HighPart");
			NativeFieldInfoPtr_QuadPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LARGE_INTEGER>.NativeClassPtr, "QuadPart");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LARGE_INTEGER>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFile_Internal_Static_SafeFileHandle_String_DesiredAccess_ShareMode_IntPtr_CreationDisposition_FlagsAndAttributes_SafeFileHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteFile_Internal_Static_Boolean_SafeFileHandle_Il2CppStructArray_1_Byte_Int32_byref_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadFile_Internal_Static_Boolean_SafeFileHandle_Il2CppStructArray_1_Byte_Int32_byref_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFileSizeEx_Internal_Static_Boolean_SafeFileHandle_byref_LARGE_INTEGER_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFilePointerEx_Internal_Static_Boolean_SafeFileHandle_LARGE_INTEGER_byref_LARGE_INTEGER_SeekOrigin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEndOfFile_Internal_Static_Boolean_SafeFileHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlushFileBuffers_Internal_Static_Boolean_SafeFileHandle_0;

	static FileApi()
	{
		Il2CppClassPointerStore<FileApi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Win32", "FileApi");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileApi>.NativeClassPtr);
		NativeMethodInfoPtr_CreateFile_Internal_Static_SafeFileHandle_String_DesiredAccess_ShareMode_IntPtr_CreationDisposition_FlagsAndAttributes_SafeFileHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileApi>.NativeClassPtr, 100664184);
		NativeMethodInfoPtr_WriteFile_Internal_Static_Boolean_SafeFileHandle_Il2CppStructArray_1_Byte_Int32_byref_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileApi>.NativeClassPtr, 100664185);
		NativeMethodInfoPtr_ReadFile_Internal_Static_Boolean_SafeFileHandle_Il2CppStructArray_1_Byte_Int32_byref_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileApi>.NativeClassPtr, 100664186);
		NativeMethodInfoPtr_GetFileSizeEx_Internal_Static_Boolean_SafeFileHandle_byref_LARGE_INTEGER_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileApi>.NativeClassPtr, 100664187);
		NativeMethodInfoPtr_SetFilePointerEx_Internal_Static_Boolean_SafeFileHandle_LARGE_INTEGER_byref_LARGE_INTEGER_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileApi>.NativeClassPtr, 100664188);
		NativeMethodInfoPtr_SetEndOfFile_Internal_Static_Boolean_SafeFileHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileApi>.NativeClassPtr, 100664189);
		NativeMethodInfoPtr_FlushFileBuffers_Internal_Static_Boolean_SafeFileHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileApi>.NativeClassPtr, 100664190);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40069, RefRangeEnd = 40070, XrefRangeStart = 40058, XrefRangeEnd = 40069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SafeFileHandle CreateFile(string lpFileName, DesiredAccess dwDesiredAccess, ShareMode dwShareMode, System.IntPtr lpSecurityAttributess, CreationDisposition dwCreationDisposition, FlagsAndAttributes dwFlagsAndAttributes, SafeFileHandle hTemplateFile)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(lpFileName);
		*(DesiredAccess**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwDesiredAccess;
		*(ShareMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwShareMode;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lpSecurityAttributess;
		*(CreationDisposition**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwCreationDisposition;
		*(FlagsAndAttributes**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwFlagsAndAttributes;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hTemplateFile);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFile_Internal_Static_SafeFileHandle_String_DesiredAccess_ShareMode_IntPtr_CreationDisposition_FlagsAndAttributes_SafeFileHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SafeFileHandle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40075, RefRangeEnd = 40076, XrefRangeStart = 40070, XrefRangeEnd = 40075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool WriteFile(SafeFileHandle handle, Il2CppStructArray<byte> bytes, int numBytesToWrite, out int numBytesWrite, System.IntPtr overlapped_MustBeZero)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numBytesToWrite;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref numBytesWrite);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &overlapped_MustBeZero;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteFile_Internal_Static_Boolean_SafeFileHandle_Il2CppStructArray_1_Byte_Int32_byref_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40081, RefRangeEnd = 40082, XrefRangeStart = 40076, XrefRangeEnd = 40081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ReadFile(SafeFileHandle handle, Il2CppStructArray<byte> buffer, int numBytesToRead, out int numBytesRead, System.IntPtr overlapped_MustBeZero)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numBytesToRead;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref numBytesRead);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &overlapped_MustBeZero;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadFile_Internal_Static_Boolean_SafeFileHandle_Il2CppStructArray_1_Byte_Int32_byref_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40087, RefRangeEnd = 40088, XrefRangeStart = 40082, XrefRangeEnd = 40087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetFileSizeEx(SafeFileHandle hFile, ref LARGE_INTEGER lpFileSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hFile);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpFileSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFileSizeEx_Internal_Static_Boolean_SafeFileHandle_byref_LARGE_INTEGER_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 40093, RefRangeEnd = 40101, XrefRangeStart = 40088, XrefRangeEnd = 40093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetFilePointerEx(SafeFileHandle hFile, LARGE_INTEGER liDistanceToMove, ref LARGE_INTEGER lpNewFilePointer, SeekOrigin dwMoveMethod)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hFile);
		*(LARGE_INTEGER**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &liDistanceToMove;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpNewFilePointer);
		*(SeekOrigin**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwMoveMethod;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFilePointerEx_Internal_Static_Boolean_SafeFileHandle_LARGE_INTEGER_byref_LARGE_INTEGER_SeekOrigin_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40106, RefRangeEnd = 40107, XrefRangeStart = 40101, XrefRangeEnd = 40106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetEndOfFile(SafeFileHandle hFile)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hFile);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEndOfFile_Internal_Static_Boolean_SafeFileHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40112, RefRangeEnd = 40113, XrefRangeStart = 40107, XrefRangeEnd = 40112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FlushFileBuffers(SafeFileHandle hFile)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hFile);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlushFileBuffers_Internal_Static_Boolean_SafeFileHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public FileApi(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
