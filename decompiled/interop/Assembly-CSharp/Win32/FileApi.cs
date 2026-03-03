using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace Win32;

[Token(Token = "0x20000C0")]
public static class FileApi
{
	[Token(Token = "0x20000C1")]
	public enum DesiredAccess : uint
	{
		[Token(Token = "0x40003DD")]
		GENERIC_ALL = 0x10000000u,
		[Token(Token = "0x40003DE")]
		GENERIC_EXECUTE = 0x20000000u,
		[Token(Token = "0x40003DF")]
		GENERIC_WRITE = 0x40000000u,
		[Token(Token = "0x40003E0")]
		GENERIC_READ = 0x80000000u
	}

	[Token(Token = "0x20000C2")]
	public enum ShareMode : uint
	{
		[Token(Token = "0x40003E2")]
		FILE_SHARE_NONE = 0u,
		[Token(Token = "0x40003E3")]
		FILE_SHARE_READ = 1u,
		[Token(Token = "0x40003E4")]
		FILE_SHARE_WRITE = 2u,
		[Token(Token = "0x40003E5")]
		FILE_SHARE_DELETE = 4u
	}

	[Token(Token = "0x20000C3")]
	public enum CreationDisposition : uint
	{
		[Token(Token = "0x40003E7")]
		CREATE_NEW = 1u,
		[Token(Token = "0x40003E8")]
		CREATE_ALWAYS,
		[Token(Token = "0x40003E9")]
		OPEN_EXISTING,
		[Token(Token = "0x40003EA")]
		OPEN_ALWAYS,
		[Token(Token = "0x40003EB")]
		TRUNCATE_EXISTING
	}

	[Token(Token = "0x20000C4")]
	public enum FlagsAndAttributes : uint
	{
		[Token(Token = "0x40003ED")]
		FILE_ATTRIBUTE_READONLY = 1u,
		[Token(Token = "0x40003EE")]
		FILE_ATTRIBUTE_HIDDEN = 2u,
		[Token(Token = "0x40003EF")]
		FILE_ATTRIBUTE_SYSTEM = 4u,
		[Token(Token = "0x40003F0")]
		FILE_ATTRIBUTE_DIRECTORY = 16u,
		[Token(Token = "0x40003F1")]
		FILE_ATTRIBUTE_ARCHIVE = 32u,
		[Token(Token = "0x40003F2")]
		FILE_ATTRIBUTE_DEVICE = 64u,
		[Token(Token = "0x40003F3")]
		FILE_ATTRIBUTE_NORMAL = 128u,
		[Token(Token = "0x40003F4")]
		FILE_ATTRIBUTE_TEMPORARY = 256u,
		[Token(Token = "0x40003F5")]
		FILE_ATTRIBUTE_SPARSE_FILE = 512u,
		[Token(Token = "0x40003F6")]
		FILE_ATTRIBUTE_REPARSE_POINT = 1024u,
		[Token(Token = "0x40003F7")]
		FILE_ATTRIBUTE_COMPRESSED = 2048u,
		[Token(Token = "0x40003F8")]
		FILE_ATTRIBUTE_OFFLINE = 4096u,
		[Token(Token = "0x40003F9")]
		FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 8192u,
		[Token(Token = "0x40003FA")]
		FILE_ATTRIBUTE_ENCRYPTED = 16384u,
		[Token(Token = "0x40003FB")]
		FILE_ATTRIBUTE_VIRTUAL = 65536u,
		[Token(Token = "0x40003FC")]
		FILE_ATTRIBUTE_VALID_FLAGS = 32695u,
		[Token(Token = "0x40003FD")]
		FILE_ATTRIBUTE_VALID_SET_FLAGS = 12711u,
		[Token(Token = "0x40003FE")]
		FILE_FLAG_OVERLAPPED = 1073741824u
	}

	[Token(Token = "0x20000C5")]
	public enum SeekOrigin : uint
	{
		[Token(Token = "0x4000400")]
		FILE_BEGIN,
		[Token(Token = "0x4000401")]
		FILE_CURRENT,
		[Token(Token = "0x4000402")]
		FILE_END
	}

	[StructLayout(2)]
	[Token(Token = "0x20000C6")]
	internal struct LARGE_INTEGER
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int LowPart;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal int HighPart;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal long QuadPart;
	}

	[PreserveSig]
	[Token(Token = "0x6000378")]
	[Address(RVA = "0x678910", Offset = "0x677B10", VA = "0x180678910")]
	internal static extern SafeFileHandle CreateFile(string lpFileName, DesiredAccess dwDesiredAccess, ShareMode dwShareMode, IntPtr lpSecurityAttributess, CreationDisposition dwCreationDisposition, FlagsAndAttributes dwFlagsAndAttributes, SafeFileHandle hTemplateFile);

	[PreserveSig]
	[Token(Token = "0x6000379")]
	[Address(RVA = "0x678F50", Offset = "0x678150", VA = "0x180678F50")]
	internal static extern bool WriteFile(SafeFileHandle handle, byte[] bytes, int numBytesToWrite, out int numBytesWrite, IntPtr overlapped_MustBeZero);

	[PreserveSig]
	[Token(Token = "0x600037A")]
	[Address(RVA = "0x678C50", Offset = "0x677E50", VA = "0x180678C50")]
	internal static extern bool ReadFile(SafeFileHandle handle, byte[] buffer, int numBytesToRead, out int numBytesRead, IntPtr overlapped_MustBeZero);

	[PreserveSig]
	[Token(Token = "0x600037B")]
	[Address(RVA = "0x678B70", Offset = "0x677D70", VA = "0x180678B70")]
	internal static extern bool GetFileSizeEx(SafeFileHandle hFile, ref LARGE_INTEGER lpFileSize);

	[PreserveSig]
	[Token(Token = "0x600037C")]
	[Address(RVA = "0x678E50", Offset = "0x678050", VA = "0x180678E50")]
	internal static extern bool SetFilePointerEx(SafeFileHandle hFile, LARGE_INTEGER liDistanceToMove, ref LARGE_INTEGER lpNewFilePointer, SeekOrigin dwMoveMethod);

	[PreserveSig]
	[Token(Token = "0x600037D")]
	[Address(RVA = "0x678D70", Offset = "0x677F70", VA = "0x180678D70")]
	internal static extern bool SetEndOfFile(SafeFileHandle hFile);

	[PreserveSig]
	[Token(Token = "0x600037E")]
	[Address(RVA = "0x678A90", Offset = "0x677C90", VA = "0x180678A90")]
	internal static extern bool FlushFileBuffers(SafeFileHandle hFile);
}
