using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.IO;

public static class MonoIO : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_InvalidHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_dump_handles;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetException_Public_Static_Exception_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetException_Public_Static_Exception_String_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFileType_Private_Static_MonoFileType_IntPtr_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFileType_Public_Static_MonoFileType_SafeHandle_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindCloseFile_Public_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Private_Static_IntPtr_ptr_Char_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Static_IntPtr_String_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Static_Boolean_IntPtr_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Seek_Private_Static_Int64_IntPtr_Int64_SeekOrigin_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Seek_Public_Static_Int64_SafeHandle_Int64_SeekOrigin_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLength_Private_Static_Int64_IntPtr_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLength_Public_Static_Int64_SafeHandle_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLength_Private_Static_Boolean_IntPtr_Int64_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLength_Public_Static_Boolean_SafeHandle_Int64_byref_MonoIOError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ConsoleOutput_Public_Static_get_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ConsoleInput_Public_Static_get_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ConsoleError_Public_Static_get_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_VolumeSeparatorChar_Public_Static_get_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AltDirectorySeparatorChar_Public_Static_get_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PathSeparator_Public_Static_get_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DumpHandles_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemapPath_Public_Static_Boolean_String_byref_String_0;

	public unsafe static System.IntPtr InvalidHandle
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InvalidHandle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InvalidHandle, (void*)(&value));
		}
	}

	public unsafe static bool dump_handles
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dump_handles, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dump_handles, (void*)(&value));
		}
	}

	public unsafe static System.IntPtr ConsoleOutput
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 838448, RefRangeEnd = 838450, XrefRangeStart = 838447, XrefRangeEnd = 838448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConsoleOutput_Public_Static_get_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static System.IntPtr ConsoleInput
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 838451, RefRangeEnd = 838453, XrefRangeStart = 838450, XrefRangeEnd = 838451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConsoleInput_Public_Static_get_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static System.IntPtr ConsoleError
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 838454, RefRangeEnd = 838455, XrefRangeStart = 838453, XrefRangeEnd = 838454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConsoleError_Public_Static_get_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static char VolumeSeparatorChar
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838455, XrefRangeEnd = 838456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_VolumeSeparatorChar_Public_Static_get_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static char DirectorySeparatorChar
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838456, XrefRangeEnd = 838457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static char AltDirectorySeparatorChar
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838457, XrefRangeEnd = 838458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AltDirectorySeparatorChar_Public_Static_get_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static char PathSeparator
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838458, XrefRangeEnd = 838459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PathSeparator_Public_Static_get_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static MonoIO()
	{
		Il2CppClassPointerStore<MonoIO>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "MonoIO");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoIO>.NativeClassPtr);
		NativeFieldInfoPtr_InvalidHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, "InvalidHandle");
		NativeFieldInfoPtr_dump_handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, "dump_handles");
		NativeMethodInfoPtr_GetException_Public_Static_Exception_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675020);
		NativeMethodInfoPtr_GetException_Public_Static_Exception_String_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675021);
		NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675022);
		NativeMethodInfoPtr_GetFileType_Private_Static_MonoFileType_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675023);
		NativeMethodInfoPtr_GetFileType_Public_Static_MonoFileType_SafeHandle_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675024);
		NativeMethodInfoPtr_FindCloseFile_Public_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675025);
		NativeMethodInfoPtr_Open_Private_Static_IntPtr_ptr_Char_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675026);
		NativeMethodInfoPtr_Open_Public_Static_IntPtr_String_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675027);
		NativeMethodInfoPtr_Close_Public_Static_Boolean_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675028);
		NativeMethodInfoPtr_Read_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675029);
		NativeMethodInfoPtr_Read_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675030);
		NativeMethodInfoPtr_Write_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675031);
		NativeMethodInfoPtr_Write_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675032);
		NativeMethodInfoPtr_Seek_Private_Static_Int64_IntPtr_Int64_SeekOrigin_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675033);
		NativeMethodInfoPtr_Seek_Public_Static_Int64_SafeHandle_Int64_SeekOrigin_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675034);
		NativeMethodInfoPtr_GetLength_Private_Static_Int64_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675035);
		NativeMethodInfoPtr_GetLength_Public_Static_Int64_SafeHandle_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675036);
		NativeMethodInfoPtr_SetLength_Private_Static_Boolean_IntPtr_Int64_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675037);
		NativeMethodInfoPtr_SetLength_Public_Static_Boolean_SafeHandle_Int64_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675038);
		NativeMethodInfoPtr_get_ConsoleOutput_Public_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675039);
		NativeMethodInfoPtr_get_ConsoleInput_Public_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675040);
		NativeMethodInfoPtr_get_ConsoleError_Public_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675041);
		NativeMethodInfoPtr_get_VolumeSeparatorChar_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675042);
		NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675043);
		NativeMethodInfoPtr_get_AltDirectorySeparatorChar_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675044);
		NativeMethodInfoPtr_get_PathSeparator_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675045);
		NativeMethodInfoPtr_DumpHandles_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675046);
		NativeMethodInfoPtr_RemapPath_Public_Static_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100675047);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838212, XrefRangeEnd = 838221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception GetException(MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetException_Public_Static_Exception_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838221, XrefRangeEnd = 838362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception GetException(string path, MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(MonoIOError**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &error;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetException_Public_Static_Exception_String_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 838363, RefRangeEnd = 838364, XrefRangeStart = 838362, XrefRangeEnd = 838363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetCurrentDirectory(out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838364, XrefRangeEnd = 838365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MonoFileType GetFileType(System.IntPtr handle, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFileType_Private_Static_MonoFileType_IntPtr_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MonoFileType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 838373, RefRangeEnd = 838375, XrefRangeStart = 838365, XrefRangeEnd = 838373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MonoFileType GetFileType(Il2CppSystem.Runtime.InteropServices.SafeHandle safeHandle, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFileType_Public_Static_MonoFileType_SafeHandle_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MonoFileType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 838376, RefRangeEnd = 838377, XrefRangeStart = 838375, XrefRangeEnd = 838376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FindCloseFile(System.IntPtr hnd)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hnd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindCloseFile_Public_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838377, XrefRangeEnd = 838378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)filename;
		*(FileMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		*(FileAccess**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &access;
		*(FileShare**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &share;
		*(FileOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Open_Private_Static_IntPtr_ptr_Char_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838378, XrefRangeEnd = 838383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		*(FileMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		*(FileAccess**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &access;
		*(FileShare**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &share;
		*(FileOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Open_Public_Static_IntPtr_String_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 838384, RefRangeEnd = 838385, XrefRangeStart = 838383, XrefRangeEnd = 838384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Close(System.IntPtr handle, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_Public_Static_Boolean_IntPtr_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838385, XrefRangeEnd = 838386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Read(System.IntPtr handle, Il2CppStructArray<byte> dest, int dest_offset, int count, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&handle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dest_offset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Read_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 838394, RefRangeEnd = 838395, XrefRangeStart = 838386, XrefRangeEnd = 838394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Read(Il2CppSystem.Runtime.InteropServices.SafeHandle safeHandle, Il2CppStructArray<byte> dest, int dest_offset, int count, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dest_offset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Read_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838395, XrefRangeEnd = 838403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Write(System.IntPtr handle, [System.Runtime.InteropServices.In] Il2CppStructArray<byte> src, int src_offset, int count, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&handle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_offset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Write_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 838411, RefRangeEnd = 838413, XrefRangeStart = 838403, XrefRangeEnd = 838411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Write(Il2CppSystem.Runtime.InteropServices.SafeHandle safeHandle, Il2CppStructArray<byte> src, int src_offset, int count, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &src_offset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Write_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838413, XrefRangeEnd = 838414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long Seek(System.IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&handle);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(SeekOrigin**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Seek_Private_Static_Int64_IntPtr_Int64_SeekOrigin_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 838422, RefRangeEnd = 838427, XrefRangeStart = 838414, XrefRangeEnd = 838422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long Seek(Il2CppSystem.Runtime.InteropServices.SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(SeekOrigin**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Seek_Public_Static_Int64_SafeHandle_Int64_SeekOrigin_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838427, XrefRangeEnd = 838428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long GetLength(System.IntPtr handle, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLength_Private_Static_Int64_IntPtr_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 838436, RefRangeEnd = 838437, XrefRangeStart = 838428, XrefRangeEnd = 838436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long GetLength(Il2CppSystem.Runtime.InteropServices.SafeHandle safeHandle, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLength_Public_Static_Int64_SafeHandle_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838437, XrefRangeEnd = 838438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetLength(System.IntPtr handle, long length, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&handle);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLength_Private_Static_Boolean_IntPtr_Int64_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 838446, RefRangeEnd = 838447, XrefRangeStart = 838438, XrefRangeEnd = 838446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetLength(Il2CppSystem.Runtime.InteropServices.SafeHandle safeHandle, long length, out MonoIOError error)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)safeHandle);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLength_Public_Static_Boolean_SafeHandle_Int64_byref_MonoIOError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DumpHandles()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DumpHandles_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 838459, XrefRangeEnd = 838460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RemapPath(string path, out string newPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemapPath_Public_Static_Boolean_String_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		newPath = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public MonoIO(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
