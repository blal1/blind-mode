using System.IO;
using Il2CppDummyDll;

namespace Ionic.Zlib;

[Token(Token = "0x20000E0")]
internal class ZlibBaseStream : Stream
{
	[Token(Token = "0x20000E1")]
	internal enum StreamMode
	{
		[Token(Token = "0x4000521")]
		Writer,
		[Token(Token = "0x4000522")]
		Reader,
		[Token(Token = "0x4000523")]
		Undefined
	}

	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0x28")]
	protected internal ZlibCodec _z;

	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x30")]
	protected internal StreamMode _streamMode;

	[Token(Token = "0x4000515")]
	[FieldOffset(Offset = "0x34")]
	protected internal FlushType _flushMode;

	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x38")]
	protected internal ZlibStreamFlavor _flavor;

	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x3C")]
	protected internal CompressionMode _compressionMode;

	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x40")]
	protected internal CompressionLevel _level;

	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0x44")]
	protected internal bool _leaveOpen;

	[Token(Token = "0x400051A")]
	[FieldOffset(Offset = "0x48")]
	protected internal byte[] _workingBuffer;

	[Token(Token = "0x400051B")]
	[FieldOffset(Offset = "0x50")]
	protected internal int _bufferSize;

	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0x58")]
	protected internal byte[] _buf1;

	[Token(Token = "0x400051D")]
	[FieldOffset(Offset = "0x60")]
	protected internal Stream _stream;

	[Token(Token = "0x400051E")]
	[FieldOffset(Offset = "0x68")]
	protected internal CompressionStrategy Strategy;

	[Token(Token = "0x400051F")]
	[FieldOffset(Offset = "0x6C")]
	private bool nomoreinput;

	[Token(Token = "0x17000060")]
	protected internal bool _wantCompress
	{
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x79B410", Offset = "0x79A610", VA = "0x18079B410")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000061")]
	private ZlibCodec z
	{
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x79B480", Offset = "0x79A680", VA = "0x18079B480")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000062")]
	private byte[] workingBuffer
	{
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x79B420", Offset = "0x79A620", VA = "0x18079B420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000063")]
	public override bool CanRead
	{
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x79B310", Offset = "0x79A510", VA = "0x18079B310", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000064")]
	public override bool CanSeek
	{
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x79B340", Offset = "0x79A540", VA = "0x18079B340", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000065")]
	public override bool CanWrite
	{
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x79B370", Offset = "0x79A570", VA = "0x18079B370", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000066")]
	public override long Length
	{
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x79B3A0", Offset = "0x79A5A0", VA = "0x18079B3A0", Slot = "11")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000067")]
	public override long Position
	{
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x79B3D0", Offset = "0x79A5D0", VA = "0x18079B3D0", Slot = "12")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x79B570", Offset = "0x79A770", VA = "0x18079B570", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x79AD40", Offset = "0x799F40", VA = "0x18079AD40")]
	public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x79A9D0", Offset = "0x799BD0", VA = "0x18079A9D0", Slot = "35")]
	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x79AF80", Offset = "0x79A180", VA = "0x18079AF80")]
	private void finish()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x79AE20", Offset = "0x79A020", VA = "0x18079AE20")]
	private void end()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x79A020", Offset = "0x799220", VA = "0x18079A020", Slot = "19")]
	protected override void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x79A0A0", Offset = "0x7992A0", VA = "0x18079A0A0", Slot = "20")]
	public override void Flush()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x79A740", Offset = "0x799940", VA = "0x18079A740", Slot = "30")]
	public override long Seek(long offset, SeekOrigin origin)
	{
		return default(long);
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x79A780", Offset = "0x799980", VA = "0x18079A780", Slot = "31")]
	public override void SetLength(long value)
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x79A0D0", Offset = "0x7992D0", VA = "0x18079A0D0", Slot = "32")]
	public override int Read(byte[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x799F50", Offset = "0x799150", VA = "0x180799F50")]
	public static void CompressBuffer(byte[] b, Stream compressor)
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x79A7B0", Offset = "0x7999B0", VA = "0x18079A7B0")]
	public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor)
	{
		return null;
	}
}
