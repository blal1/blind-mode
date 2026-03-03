using System.IO;
using Il2CppDummyDll;

namespace Ionic.Zlib;

[Token(Token = "0x20000CD")]
public class DeflateStream : Stream
{
	[Token(Token = "0x400045F")]
	[FieldOffset(Offset = "0x28")]
	internal ZlibBaseStream _baseStream;

	[Token(Token = "0x4000460")]
	[FieldOffset(Offset = "0x30")]
	internal Stream _innerStream;

	[Token(Token = "0x4000461")]
	[FieldOffset(Offset = "0x38")]
	private bool _disposed;

	[Token(Token = "0x17000055")]
	public virtual FlushType FlushMode
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x678530", Offset = "0x677730", VA = "0x180678530", Slot = "38")]
		get
		{
			return default(FlushType);
		}
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x6787D0", Offset = "0x6779D0", VA = "0x1806787D0", Slot = "39")]
		set
		{
		}
	}

	[Token(Token = "0x17000056")]
	public int BufferSize
	{
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x6783F0", Offset = "0x6775F0", VA = "0x1806783F0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x678660", Offset = "0x677860", VA = "0x180678660")]
		set
		{
		}
	}

	[Token(Token = "0x17000057")]
	public CompressionStrategy Strategy
	{
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x6785E0", Offset = "0x6777E0", VA = "0x1806785E0")]
		get
		{
			return default(CompressionStrategy);
		}
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x678890", Offset = "0x677A90", VA = "0x180678890")]
		set
		{
		}
	}

	[Token(Token = "0x17000058")]
	public virtual long TotalIn
	{
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x678600", Offset = "0x677800", VA = "0x180678600", Slot = "40")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000059")]
	public virtual long TotalOut
	{
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x678630", Offset = "0x677830", VA = "0x180678630", Slot = "41")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700005A")]
	public override bool CanRead
	{
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x678410", Offset = "0x677610", VA = "0x180678410", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700005B")]
	public override bool CanSeek
	{
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700005C")]
	public override bool CanWrite
	{
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x6784A0", Offset = "0x6776A0", VA = "0x1806784A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700005D")]
	public override long Length
	{
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x678550", Offset = "0x677750", VA = "0x180678550", Slot = "11")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700005E")]
	public override long Position
	{
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x678590", Offset = "0x677790", VA = "0x180678590", Slot = "12")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x678850", Offset = "0x677A50", VA = "0x180678850", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x678280", Offset = "0x677480", VA = "0x180678280")]
	public DeflateStream(Stream stream, CompressionMode mode)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x6782E0", Offset = "0x6774E0", VA = "0x1806782E0")]
	public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x6782B0", Offset = "0x6774B0", VA = "0x1806782B0")]
	public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x678300", Offset = "0x677500", VA = "0x180678300")]
	public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x677E90", Offset = "0x677090", VA = "0x180677E90", Slot = "19")]
	protected override void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x677F20", Offset = "0x677120", VA = "0x180677F20", Slot = "20")]
	public override void Flush()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x677FB0", Offset = "0x6771B0", VA = "0x180677FB0", Slot = "32")]
	public override int Read(byte[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x678040", Offset = "0x677240", VA = "0x180678040", Slot = "30")]
	public override long Seek(long offset, SeekOrigin origin)
	{
		return default(long);
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x678080", Offset = "0x677280", VA = "0x180678080", Slot = "31")]
	public override void SetLength(long value)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x6781F0", Offset = "0x6773F0", VA = "0x1806781F0", Slot = "35")]
	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x677D40", Offset = "0x676F40", VA = "0x180677D40")]
	public static byte[] CompressBuffer(byte[] b)
	{
		return null;
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x6780C0", Offset = "0x6772C0", VA = "0x1806780C0")]
	public static byte[] UncompressBuffer(byte[] compressed)
	{
		return null;
	}
}
