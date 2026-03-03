using Il2CppDummyDll;

namespace Ionic.Zlib;

[Token(Token = "0x20000CE")]
internal sealed class InflateBlocks
{
	[Token(Token = "0x20000CF")]
	private enum InflateBlockMode
	{
		[Token(Token = "0x4000479")]
		TYPE,
		[Token(Token = "0x400047A")]
		LENS,
		[Token(Token = "0x400047B")]
		STORED,
		[Token(Token = "0x400047C")]
		TABLE,
		[Token(Token = "0x400047D")]
		BTREE,
		[Token(Token = "0x400047E")]
		DTREE,
		[Token(Token = "0x400047F")]
		CODES,
		[Token(Token = "0x4000480")]
		DRY,
		[Token(Token = "0x4000481")]
		DONE,
		[Token(Token = "0x4000482")]
		BAD
	}

	[Token(Token = "0x4000462")]
	private const int MANY = 1440;

	[Token(Token = "0x4000463")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly int[] border;

	[Token(Token = "0x4000464")]
	[FieldOffset(Offset = "0x10")]
	private InflateBlockMode mode;

	[Token(Token = "0x4000465")]
	[FieldOffset(Offset = "0x14")]
	internal int left;

	[Token(Token = "0x4000466")]
	[FieldOffset(Offset = "0x18")]
	internal int table;

	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0x1C")]
	internal int index;

	[Token(Token = "0x4000468")]
	[FieldOffset(Offset = "0x20")]
	internal int[] blens;

	[Token(Token = "0x4000469")]
	[FieldOffset(Offset = "0x28")]
	internal int[] bb;

	[Token(Token = "0x400046A")]
	[FieldOffset(Offset = "0x30")]
	internal int[] tb;

	[Token(Token = "0x400046B")]
	[FieldOffset(Offset = "0x38")]
	internal InflateCodes codes;

	[Token(Token = "0x400046C")]
	[FieldOffset(Offset = "0x40")]
	internal int last;

	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x48")]
	internal ZlibCodec _codec;

	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x50")]
	internal int bitk;

	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x54")]
	internal int bitb;

	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x58")]
	internal int[] hufts;

	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x60")]
	internal byte[] window;

	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x68")]
	internal int end;

	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0x6C")]
	internal int readAt;

	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x70")]
	internal int writeAt;

	[Token(Token = "0x4000475")]
	[FieldOffset(Offset = "0x78")]
	internal object checkfn;

	[Token(Token = "0x4000476")]
	[FieldOffset(Offset = "0x80")]
	internal uint check;

	[Token(Token = "0x4000477")]
	[FieldOffset(Offset = "0x88")]
	internal InfTree inftree;

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x67B670", Offset = "0x67A870", VA = "0x18067B670")]
	internal InflateBlocks(ZlibCodec codec, object checkfn, int w)
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x67B4D0", Offset = "0x67A6D0", VA = "0x18067B4D0")]
	internal uint Reset()
	{
		return default(uint);
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x67A1A0", Offset = "0x6793A0", VA = "0x18067A1A0")]
	internal int Process(int r)
	{
		return default(int);
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x67A160", Offset = "0x679360", VA = "0x18067A160")]
	internal void Free()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x67B580", Offset = "0x67A780", VA = "0x18067B580")]
	internal void SetDictionary(byte[] d, int start, int n)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x67B5D0", Offset = "0x67A7D0", VA = "0x18067B5D0")]
	internal int SyncPoint()
	{
		return default(int);
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x679FB0", Offset = "0x6791B0", VA = "0x180679FB0")]
	internal int Flush(int r)
	{
		return default(int);
	}
}
