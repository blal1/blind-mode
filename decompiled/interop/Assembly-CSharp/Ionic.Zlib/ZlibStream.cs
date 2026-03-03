using System.IO;
using Il2CppDummyDll;

namespace Ionic.Zlib;

[Token(Token = "0x20000E4")]
public class ZlibStream : Stream
{
	[Token(Token = "0x400053D")]
	[FieldOffset(Offset = "0x28")]
	internal ZlibBaseStream _baseStream;

	[Token(Token = "0x400053E")]
	[FieldOffset(Offset = "0x30")]
	private bool _disposed;

	[Token(Token = "0x17000069")]
	public virtual FlushType FlushMode
	{
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x678530", Offset = "0x677730", VA = "0x180678530", Slot = "38")]
		get
		{
			return default(FlushType);
		}
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x79CDD0", Offset = "0x79BFD0", VA = "0x18079CDD0", Slot = "39")]
		set
		{
		}
	}

	[Token(Token = "0x1700006A")]
	public int BufferSize
	{
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x6783F0", Offset = "0x6775F0", VA = "0x1806783F0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x79CC60", Offset = "0x79BE60", VA = "0x18079CC60")]
		set
		{
		}
	}

	[Token(Token = "0x1700006B")]
	public virtual long TotalIn
	{
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x678600", Offset = "0x677800", VA = "0x180678600", Slot = "40")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700006C")]
	public virtual long TotalOut
	{
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x678630", Offset = "0x677830", VA = "0x180678630", Slot = "41")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700006D")]
	public override bool CanRead
	{
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x79CB00", Offset = "0x79BD00", VA = "0x18079CB00", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006E")]
	public override bool CanSeek
	{
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006F")]
	public override bool CanWrite
	{
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x79CB90", Offset = "0x79BD90", VA = "0x18079CB90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000070")]
	public override long Length
	{
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x79CC20", Offset = "0x79BE20", VA = "0x18079CC20", Slot = "11")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000071")]
	public override long Position
	{
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x678590", Offset = "0x677790", VA = "0x180678590", Slot = "12")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x79CE50", Offset = "0x79C050", VA = "0x18079CE50", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x79C930", Offset = "0x79BB30", VA = "0x18079C930")]
	public ZlibStream(Stream stream, CompressionMode mode)
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x79C960", Offset = "0x79BB60", VA = "0x18079C960")]
	public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level)
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x79C980", Offset = "0x79BB80", VA = "0x18079C980")]
	public ZlibStream(Stream stream, CompressionMode mode, bool leaveOpen)
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x79C9B0", Offset = "0x79BBB0", VA = "0x18079C9B0")]
	public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x79C540", Offset = "0x79B740", VA = "0x18079C540", Slot = "19")]
	protected override void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x79C5D0", Offset = "0x79B7D0", VA = "0x18079C5D0", Slot = "20")]
	public override void Flush()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x79C660", Offset = "0x79B860", VA = "0x18079C660", Slot = "32")]
	public override int Read(byte[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x79C6F0", Offset = "0x79B8F0", VA = "0x18079C6F0", Slot = "30")]
	public override long Seek(long offset, SeekOrigin origin)
	{
		return default(long);
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x79C730", Offset = "0x79B930", VA = "0x18079C730", Slot = "31")]
	public override void SetLength(long value)
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x79C8A0", Offset = "0x79BAA0", VA = "0x18079C8A0", Slot = "35")]
	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x79C3F0", Offset = "0x79B5F0", VA = "0x18079C3F0")]
	public static byte[] CompressBuffer(byte[] b)
	{
		return null;
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x79C770", Offset = "0x79B970", VA = "0x18079C770")]
	public static byte[] UncompressBuffer(byte[] compressed)
	{
		return null;
	}
}
