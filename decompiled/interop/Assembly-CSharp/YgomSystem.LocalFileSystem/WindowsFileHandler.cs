using System.IO;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002F7")]
public class WindowsFileHandler : IFileHandler
{
	[Token(Token = "0x4001013")]
	[FieldOffset(Offset = "0x0")]
	private static SafeFileHandle nullHandle;

	[Token(Token = "0x4001014")]
	[FieldOffset(Offset = "0x10")]
	private SafeFileHandle m_handle;

	[Token(Token = "0x170001DC")]
	public bool isValid
	{
		[Token(Token = "0x6001271")]
		[Address(RVA = "0x41FDD0", Offset = "0x41EFD0", VA = "0x18041FDD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600126E")]
	[Address(RVA = "0x41FD50", Offset = "0x41EF50", VA = "0x18041FD50")]
	static WindowsFileHandler()
	{
	}

	[Token(Token = "0x600126F")]
	[Address(RVA = "0x41F890", Offset = "0x41EA90", VA = "0x18041F890", Slot = "4")]
	public bool Open(string nativePath, StreamOpenMode openMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6001270")]
	[Address(RVA = "0x41F760", Offset = "0x41E960", VA = "0x18041F760", Slot = "5")]
	public void Close()
	{
	}

	[Token(Token = "0x6001272")]
	[Address(RVA = "0x41FC50", Offset = "0x41EE50", VA = "0x18041FC50", Slot = "7")]
	public int Write(byte[] data, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6001273")]
	[Address(RVA = "0x41F9E0", Offset = "0x41EBE0", VA = "0x18041F9E0", Slot = "8")]
	public int Read(byte[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6001274")]
	[Address(RVA = "0x41FAF0", Offset = "0x41ECF0", VA = "0x18041FAF0", Slot = "9")]
	public long Seek(long offset, SeekOrigin origin)
	{
		return default(long);
	}

	[Token(Token = "0x6001275")]
	[Address(RVA = "0x41F7E0", Offset = "0x41E9E0", VA = "0x18041F7E0", Slot = "10")]
	public long GetSeek()
	{
		return default(long);
	}

	[Token(Token = "0x6001276")]
	[Address(RVA = "0x41F820", Offset = "0x41EA20", VA = "0x18041F820", Slot = "11")]
	public long GetSize()
	{
		return default(long);
	}

	[Token(Token = "0x6001277")]
	[Address(RVA = "0x41FB30", Offset = "0x41ED30", VA = "0x18041FB30", Slot = "12")]
	public long SetSize(long size)
	{
		return default(long);
	}

	[Token(Token = "0x6001278")]
	[Address(RVA = "0x41F7C0", Offset = "0x41E9C0", VA = "0x18041F7C0", Slot = "13")]
	public bool Flush()
	{
		return default(bool);
	}

	[Token(Token = "0x6001279")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public WindowsFileHandler()
	{
	}
}
