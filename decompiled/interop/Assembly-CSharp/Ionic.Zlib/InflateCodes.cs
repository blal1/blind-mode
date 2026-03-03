using Il2CppDummyDll;

namespace Ionic.Zlib;

[Token(Token = "0x20000D1")]
internal sealed class InflateCodes
{
	[Token(Token = "0x4000484")]
	private const int START = 0;

	[Token(Token = "0x4000485")]
	private const int LEN = 1;

	[Token(Token = "0x4000486")]
	private const int LENEXT = 2;

	[Token(Token = "0x4000487")]
	private const int DIST = 3;

	[Token(Token = "0x4000488")]
	private const int DISTEXT = 4;

	[Token(Token = "0x4000489")]
	private const int COPY = 5;

	[Token(Token = "0x400048A")]
	private const int LIT = 6;

	[Token(Token = "0x400048B")]
	private const int WASH = 7;

	[Token(Token = "0x400048C")]
	private const int END = 8;

	[Token(Token = "0x400048D")]
	private const int BADCODE = 9;

	[Token(Token = "0x400048E")]
	[FieldOffset(Offset = "0x10")]
	internal int mode;

	[Token(Token = "0x400048F")]
	[FieldOffset(Offset = "0x14")]
	internal int len;

	[Token(Token = "0x4000490")]
	[FieldOffset(Offset = "0x18")]
	internal int[] tree;

	[Token(Token = "0x4000491")]
	[FieldOffset(Offset = "0x20")]
	internal int tree_index;

	[Token(Token = "0x4000492")]
	[FieldOffset(Offset = "0x24")]
	internal int need;

	[Token(Token = "0x4000493")]
	[FieldOffset(Offset = "0x28")]
	internal int lit;

	[Token(Token = "0x4000494")]
	[FieldOffset(Offset = "0x2C")]
	internal int bitsToGet;

	[Token(Token = "0x4000495")]
	[FieldOffset(Offset = "0x30")]
	internal int dist;

	[Token(Token = "0x4000496")]
	[FieldOffset(Offset = "0x34")]
	internal byte lbits;

	[Token(Token = "0x4000497")]
	[FieldOffset(Offset = "0x35")]
	internal byte dbits;

	[Token(Token = "0x4000498")]
	[FieldOffset(Offset = "0x38")]
	internal int[] ltree;

	[Token(Token = "0x4000499")]
	[FieldOffset(Offset = "0x40")]
	internal int ltree_index;

	[Token(Token = "0x400049A")]
	[FieldOffset(Offset = "0x48")]
	internal int[] dtree;

	[Token(Token = "0x400049B")]
	[FieldOffset(Offset = "0x50")]
	internal int dtree_index;

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	internal InflateCodes()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x796B90", Offset = "0x795D90", VA = "0x180796B90")]
	internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index)
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x796BF0", Offset = "0x795DF0", VA = "0x180796BF0")]
	internal int Process(InflateBlocks blocks, int r)
	{
		return default(int);
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x796230", Offset = "0x795430", VA = "0x180796230")]
	internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InflateBlocks s, ZlibCodec z)
	{
		return default(int);
	}
}
