using System;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002D6")]
public class CustomFileStream : Stream
{
	[Token(Token = "0x20002D7")]
	[Flags]
	private enum Access
	{
		[Token(Token = "0x4000F9C")]
		Readable = 1,
		[Token(Token = "0x4000F9D")]
		Writable = 2
	}

	[Token(Token = "0x4000F92")]
	[FieldOffset(Offset = "0x28")]
	protected IFileHandler m_file;

	[Token(Token = "0x4000F93")]
	[FieldOffset(Offset = "0x30")]
	private string m_nativePath;

	[Token(Token = "0x4000F94")]
	[FieldOffset(Offset = "0x38")]
	private long m_seek;

	[Token(Token = "0x4000F95")]
	[FieldOffset(Offset = "0x40")]
	protected long m_dataLength;

	[Token(Token = "0x4000F96")]
	[FieldOffset(Offset = "0x48")]
	private byte[] m_temp1ByteArray;

	[Token(Token = "0x4000F97")]
	[FieldOffset(Offset = "0x50")]
	private object m_syncObject;

	[Token(Token = "0x4000F98")]
	[FieldOffset(Offset = "0x58")]
	private Access m_access;

	[Token(Token = "0x170001C0")]
	protected bool isReadable
	{
		[Token(Token = "0x6001156")]
		[Address(RVA = "0x404820", Offset = "0x403A20", VA = "0x180404820")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001C1")]
	protected bool isWritable
	{
		[Token(Token = "0x6001157")]
		[Address(RVA = "0x404840", Offset = "0x403A40", VA = "0x180404840")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001C2")]
	public string nativePath
	{
		[Token(Token = "0x600115B")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C3")]
	public override long Position
	{
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860", Slot = "12")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001165")]
		[Address(RVA = "0x404890", Offset = "0x403A90", VA = "0x180404890", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x170001C4")]
	public override long Length
	{
		[Token(Token = "0x6001166")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850", Slot = "11")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x170001C5")]
	public override bool CanSeek
	{
		[Token(Token = "0x6001167")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001C6")]
	public override bool CanWrite
	{
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x404840", Offset = "0x403A40", VA = "0x180404840", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001C7")]
	public override bool CanRead
	{
		[Token(Token = "0x6001169")]
		[Address(RVA = "0x404820", Offset = "0x403A20", VA = "0x180404820", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001C8")]
	public override bool CanTimeout
	{
		[Token(Token = "0x600116A")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001C9")]
	public override int ReadTimeout
	{
		[Token(Token = "0x600116B")]
		[Address(RVA = "0x404870", Offset = "0x403A70", VA = "0x180404870", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600116C")]
		[Address(RVA = "0x4048B0", Offset = "0x403AB0", VA = "0x1804048B0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170001CA")]
	public override int WriteTimeout
	{
		[Token(Token = "0x600116D")]
		[Address(RVA = "0x404880", Offset = "0x403A80", VA = "0x180404880", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600116E")]
		[Address(RVA = "0x4048C0", Offset = "0x403AC0", VA = "0x1804048C0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6001158")]
	[Address(RVA = "0x404500", Offset = "0x403700", VA = "0x180404500")]
	protected CustomFileStream(string nativePath, StreamOpenMode openMode, IFileHandler fileHandler)
	{
	}

	[Token(Token = "0x6001159")]
	[Address(RVA = "0x403790", Offset = "0x402990", VA = "0x180403790", Slot = "1")]
	~CustomFileStream()
	{
	}

	[Token(Token = "0x600115A")]
	public static CustomFileStream Create<T>(string nativePath, StreamOpenMode openMode) where T : IFileHandler, new()
	{
		return null;
	}

	[Token(Token = "0x600115C")]
	[Address(RVA = "0x403710", Offset = "0x402910", VA = "0x180403710", Slot = "19")]
	protected override void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x600115D")]
	[Address(RVA = "0x403AC0", Offset = "0x402CC0", VA = "0x180403AC0", Slot = "32")]
	public override int Read(byte[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x600115E")]
	[Address(RVA = "0x4038D0", Offset = "0x402AD0", VA = "0x1804038D0", Slot = "34")]
	public override int ReadByte()
	{
		return default(int);
	}

	[Token(Token = "0x600115F")]
	[Address(RVA = "0x4042C0", Offset = "0x4034C0", VA = "0x1804042C0", Slot = "35")]
	public override void Write(byte[] data, int offset, int count)
	{
	}

	[Token(Token = "0x6001160")]
	[Address(RVA = "0x4040C0", Offset = "0x4032C0", VA = "0x1804040C0", Slot = "37")]
	public override void WriteByte(byte value)
	{
	}

	[Token(Token = "0x6001161")]
	[Address(RVA = "0x403CF0", Offset = "0x402EF0", VA = "0x180403CF0", Slot = "30")]
	public override long Seek(long offset, SeekOrigin origin)
	{
		return default(long);
	}

	[Token(Token = "0x6001162")]
	[Address(RVA = "0x403800", Offset = "0x402A00", VA = "0x180403800", Slot = "20")]
	public override void Flush()
	{
	}

	[Token(Token = "0x6001163")]
	[Address(RVA = "0x403F10", Offset = "0x403110", VA = "0x180403F10", Slot = "31")]
	public override void SetLength(long value)
	{
	}
}
