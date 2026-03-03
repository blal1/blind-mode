using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Ionic.Zlib;

[Token(Token = "0x20000E2")]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public sealed class ZlibCodec
{
	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public byte[] InputBuffer;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int NextIn;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int AvailableBytesIn;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public long TotalBytesIn;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public byte[] OutputBuffer;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int NextOut;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int AvailableBytesOut;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public long TotalBytesOut;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string Message;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	internal DeflateManager dstate;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	internal InflateManager istate;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	internal uint _Adler32;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public CompressionLevel CompressLevel;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int WindowBits;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public CompressionStrategy Strategy;

	[Token(Token = "0x17000068")]
	public int Adler32
	{
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x42D5A0", Offset = "0x42C7A0", VA = "0x18042D5A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x79C070", Offset = "0x79B270", VA = "0x18079C070")]
	public ZlibCodec()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x79BF30", Offset = "0x79B130", VA = "0x18079BF30")]
	public ZlibCodec(CompressionMode mode)
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x79BAB0", Offset = "0x79ACB0", VA = "0x18079BAB0")]
	public int InitializeInflate()
	{
		return default(int);
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x79BAC0", Offset = "0x79ACC0", VA = "0x18079BAC0")]
	public int InitializeInflate(bool expectRfc1950Header)
	{
		return default(int);
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x79B840", Offset = "0x79AA40", VA = "0x18079B840")]
	public int InitializeInflate(int windowBits)
	{
		return default(int);
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x79B850", Offset = "0x79AA50", VA = "0x18079B850")]
	public int InitializeInflate(int windowBits, bool expectRfc1950Header)
	{
		return default(int);
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x79B750", Offset = "0x79A950", VA = "0x18079B750")]
	public int Inflate(FlushType flush)
	{
		return default(int);
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x79B6A0", Offset = "0x79A8A0", VA = "0x18079B6A0")]
	public int EndInflate()
	{
		return default(int);
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x79BDC0", Offset = "0x79AFC0", VA = "0x18079BDC0")]
	public int SyncInflate()
	{
		return default(int);
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x79B7F0", Offset = "0x79A9F0", VA = "0x18079B7F0")]
	public int InitializeDeflate()
	{
		return default(int);
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x79B7E0", Offset = "0x79A9E0", VA = "0x18079B7E0")]
	public int InitializeDeflate(CompressionLevel level)
	{
		return default(int);
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x79B800", Offset = "0x79AA00", VA = "0x18079B800")]
	public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header)
	{
		return default(int);
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x79B7C0", Offset = "0x79A9C0", VA = "0x18079B7C0")]
	public int InitializeDeflate(CompressionLevel level, int bits)
	{
		return default(int);
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x79B820", Offset = "0x79AA20", VA = "0x18079B820")]
	public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header)
	{
		return default(int);
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x79BE30", Offset = "0x79B030", VA = "0x18079BE30")]
	private int _InternalInitializeDeflate(bool wantRfc1950Header)
	{
		return default(int);
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x79B5B0", Offset = "0x79A7B0", VA = "0x18079B5B0")]
	public int Deflate(FlushType flush)
	{
		return default(int);
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x79B620", Offset = "0x79A820", VA = "0x18079B620")]
	public int EndDeflate()
	{
		return default(int);
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x79BAD0", Offset = "0x79ACD0", VA = "0x18079BAD0")]
	public void ResetDeflate()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x79BB40", Offset = "0x79AD40", VA = "0x18079BB40")]
	public int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy)
	{
		return default(int);
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x79BBB0", Offset = "0x79ADB0", VA = "0x18079BBB0")]
	public int SetDictionary(byte[] dictionary)
	{
		return default(int);
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x79C090", Offset = "0x79B290", VA = "0x18079C090")]
	internal void flush_pending()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x79C240", Offset = "0x79B440", VA = "0x18079C240")]
	internal int read_buf(byte[] buf, int start, int size)
	{
		return default(int);
	}
}
