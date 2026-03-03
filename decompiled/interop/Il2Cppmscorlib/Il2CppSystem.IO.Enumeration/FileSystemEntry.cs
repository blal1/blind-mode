using System;
using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO.Enumeration;

public sealed class FileSystemEntry : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__info;

	private static readonly System.IntPtr NativeFieldInfoPtr__Directory_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__RootDirectory_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__OriginalRootDirectory_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_byref_FileSystemEntry_ptr_FILE_FULL_DIR_INFORMATION_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Directory_Public_get_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Directory_Private_set_Void_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RootDirectory_Public_get_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RootDirectory_Private_set_Void_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginalRootDirectory_Public_get_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_OriginalRootDirectory_Private_set_Void_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FileName_Public_get_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_FileAttributes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDirectory_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToFileSystemInfo_Public_FileSystemInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSpecifiedFullPath_Public_String_0;

	public unsafe Interop.NtDll.FILE_FULL_DIR_INFORMATION* _info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__info);
			return *(Interop.NtDll.FILE_FULL_DIR_INFORMATION**)num;
		}
		set
		{
			*(Interop.NtDll.FILE_FULL_DIR_INFORMATION**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__info)) = value;
		}
	}

	public unsafe ReadOnlySpan<char> _Directory_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Directory_k__BackingField);
			return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Directory_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ReadOnlySpan<char> _RootDirectory_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RootDirectory_k__BackingField);
			return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RootDirectory_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ReadOnlySpan<char> _OriginalRootDirectory_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OriginalRootDirectory_k__BackingField);
			return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OriginalRootDirectory_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ReadOnlySpan<char> Directory
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Directory_Public_get_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlySpan<char>(pointer);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Directory_Private_set_Void_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ReadOnlySpan<char> RootDirectory
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RootDirectory_Public_get_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlySpan<char>(pointer);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RootDirectory_Private_set_Void_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ReadOnlySpan<char> OriginalRootDirectory
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OriginalRootDirectory_Public_get_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlySpan<char>(pointer);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 591312, RefRangeEnd = 591315, XrefRangeStart = 591312, XrefRangeEnd = 591315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_OriginalRootDirectory_Private_set_Void_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ReadOnlySpan<char> FileName
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 839755, RefRangeEnd = 839757, XrefRangeStart = 839754, XrefRangeEnd = 839755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FileName_Public_get_ReadOnlySpan_1_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlySpan<char>(pointer);
		}
	}

	public unsafe FileAttributes Attributes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Attributes_Public_get_FileAttributes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FileAttributes*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsDirectory
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 839757, RefRangeEnd = 839758, XrefRangeStart = 839757, XrefRangeEnd = 839757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDirectory_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static FileSystemEntry()
	{
		Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO.Enumeration", "FileSystemEntry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr);
		NativeFieldInfoPtr__info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, "_info");
		NativeFieldInfoPtr__Directory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, "<Directory>k__BackingField");
		NativeFieldInfoPtr__RootDirectory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, "<RootDirectory>k__BackingField");
		NativeFieldInfoPtr__OriginalRootDirectory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, "<OriginalRootDirectory>k__BackingField");
		NativeMethodInfoPtr_Initialize_Internal_Static_Void_byref_FileSystemEntry_ptr_FILE_FULL_DIR_INFORMATION_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100675140);
		NativeMethodInfoPtr_get_Directory_Public_get_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100675141);
		NativeMethodInfoPtr_set_Directory_Private_set_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100675142);
		NativeMethodInfoPtr_get_RootDirectory_Public_get_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100675143);
		NativeMethodInfoPtr_set_RootDirectory_Private_set_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100675144);
		NativeMethodInfoPtr_get_OriginalRootDirectory_Public_get_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100675145);
		NativeMethodInfoPtr_set_OriginalRootDirectory_Private_set_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100675146);
		NativeMethodInfoPtr_get_FileName_Public_get_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100675147);
		NativeMethodInfoPtr_get_Attributes_Public_get_FileAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100675148);
		NativeMethodInfoPtr_get_IsDirectory_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100675149);
		NativeMethodInfoPtr_ToFileSystemInfo_Public_FileSystemInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100675150);
		NativeMethodInfoPtr_ToSpecifiedFullPath_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr, 100675151);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 839753, RefRangeEnd = 839754, XrefRangeStart = 839753, XrefRangeEnd = 839753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize(ref FileSystemEntry entry, Interop.NtDll.FILE_FULL_DIR_INFORMATION* info, ReadOnlySpan<char> directory, ReadOnlySpan<char> rootDirectory, ReadOnlySpan<char> originalRootDirectory)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)entry);
		*(Interop.NtDll.FILE_FULL_DIR_INFORMATION**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = info;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)directory));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rootDirectory));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)originalRootDirectory));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Static_Void_byref_FileSystemEntry_ptr_FILE_FULL_DIR_INFORMATION_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 839771, RefRangeEnd = 839774, XrefRangeStart = 839758, XrefRangeEnd = 839771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FileSystemInfo ToFileSystemInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToFileSystemInfo_Public_FileSystemInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FileSystemInfo>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 839794, RefRangeEnd = 839797, XrefRangeStart = 839774, XrefRangeEnd = 839794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToSpecifiedFullPath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSpecifiedFullPath_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public FileSystemEntry(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public FileSystemEntry()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEntry>.NativeClassPtr))
	{
	}
}
