using Il2CppDummyDll;

namespace Ionic.Zlib;

[Token(Token = "0x20000D2")]
internal sealed class InflateManager
{
	[Token(Token = "0x20000D3")]
	private enum InflateManagerMode
	{
		[Token(Token = "0x40004A9")]
		METHOD,
		[Token(Token = "0x40004AA")]
		FLAG,
		[Token(Token = "0x40004AB")]
		DICT4,
		[Token(Token = "0x40004AC")]
		DICT3,
		[Token(Token = "0x40004AD")]
		DICT2,
		[Token(Token = "0x40004AE")]
		DICT1,
		[Token(Token = "0x40004AF")]
		DICT0,
		[Token(Token = "0x40004B0")]
		BLOCKS,
		[Token(Token = "0x40004B1")]
		CHECK4,
		[Token(Token = "0x40004B2")]
		CHECK3,
		[Token(Token = "0x40004B3")]
		CHECK2,
		[Token(Token = "0x40004B4")]
		CHECK1,
		[Token(Token = "0x40004B5")]
		DONE,
		[Token(Token = "0x40004B6")]
		BAD
	}

	[Token(Token = "0x400049C")]
	private const int PRESET_DICT = 32;

	[Token(Token = "0x400049D")]
	private const int Z_DEFLATED = 8;

	[Token(Token = "0x400049E")]
	[FieldOffset(Offset = "0x10")]
	private InflateManagerMode mode;

	[Token(Token = "0x400049F")]
	[FieldOffset(Offset = "0x18")]
	internal ZlibCodec _codec;

	[Token(Token = "0x40004A0")]
	[FieldOffset(Offset = "0x20")]
	internal int method;

	[Token(Token = "0x40004A1")]
	[FieldOffset(Offset = "0x24")]
	internal uint computedCheck;

	[Token(Token = "0x40004A2")]
	[FieldOffset(Offset = "0x28")]
	internal uint expectedCheck;

	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x2C")]
	internal int marker;

	[Token(Token = "0x40004A4")]
	[FieldOffset(Offset = "0x30")]
	private bool _handleRfc1950HeaderBytes;

	[Token(Token = "0x40004A5")]
	[FieldOffset(Offset = "0x34")]
	internal int wbits;

	[Token(Token = "0x40004A6")]
	[FieldOffset(Offset = "0x38")]
	internal InflateBlocks blocks;

	[Token(Token = "0x40004A7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly byte[] mark;

	[Token(Token = "0x1700005F")]
	internal bool HandleRfc1950HeaderBytes
	{
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
		set
		{
		}
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x7987C0", Offset = "0x7979C0", VA = "0x1807987C0")]
	public InflateManager()
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x7987D0", Offset = "0x7979D0", VA = "0x1807987D0")]
	public InflateManager(bool expectRfc1950HeaderBytes)
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x7982C0", Offset = "0x7974C0", VA = "0x1807982C0")]
	internal int Reset()
	{
		return default(int);
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x7977C0", Offset = "0x7969C0", VA = "0x1807977C0")]
	internal int End()
	{
		return default(int);
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x798120", Offset = "0x797320", VA = "0x180798120")]
	internal int Initialize(ZlibCodec codec, int w)
	{
		return default(int);
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x797800", Offset = "0x796A00", VA = "0x180797800")]
	internal int Inflate(FlushType flush)
	{
		return default(int);
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x798330", Offset = "0x797530", VA = "0x180798330")]
	internal int SetDictionary(byte[] dictionary)
	{
		return default(int);
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x7984D0", Offset = "0x7976D0", VA = "0x1807984D0")]
	internal int Sync()
	{
		return default(int);
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x7984B0", Offset = "0x7976B0", VA = "0x1807984B0")]
	internal int SyncPoint(ZlibCodec z)
	{
		return default(int);
	}
}
