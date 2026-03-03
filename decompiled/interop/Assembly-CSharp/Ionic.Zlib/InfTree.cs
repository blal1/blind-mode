using Il2CppDummyDll;

namespace Ionic.Zlib;

[Token(Token = "0x20000D4")]
internal sealed class InfTree
{
	[Token(Token = "0x40004B7")]
	private const int MANY = 1440;

	[Token(Token = "0x40004B8")]
	private const int Z_OK = 0;

	[Token(Token = "0x40004B9")]
	private const int Z_STREAM_END = 1;

	[Token(Token = "0x40004BA")]
	private const int Z_NEED_DICT = 2;

	[Token(Token = "0x40004BB")]
	private const int Z_ERRNO = -1;

	[Token(Token = "0x40004BC")]
	private const int Z_STREAM_ERROR = -2;

	[Token(Token = "0x40004BD")]
	private const int Z_DATA_ERROR = -3;

	[Token(Token = "0x40004BE")]
	private const int Z_MEM_ERROR = -4;

	[Token(Token = "0x40004BF")]
	private const int Z_BUF_ERROR = -5;

	[Token(Token = "0x40004C0")]
	private const int Z_VERSION_ERROR = -6;

	[Token(Token = "0x40004C1")]
	internal const int fixed_bl = 9;

	[Token(Token = "0x40004C2")]
	internal const int fixed_bd = 5;

	[Token(Token = "0x40004C3")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly int[] fixed_tl;

	[Token(Token = "0x40004C4")]
	[FieldOffset(Offset = "0x8")]
	internal static readonly int[] fixed_td;

	[Token(Token = "0x40004C5")]
	[FieldOffset(Offset = "0x10")]
	internal static readonly int[] cplens;

	[Token(Token = "0x40004C6")]
	[FieldOffset(Offset = "0x18")]
	internal static readonly int[] cplext;

	[Token(Token = "0x40004C7")]
	[FieldOffset(Offset = "0x20")]
	internal static readonly int[] cpdist;

	[Token(Token = "0x40004C8")]
	[FieldOffset(Offset = "0x28")]
	internal static readonly int[] cpdext;

	[Token(Token = "0x40004C9")]
	internal const int BMAX = 15;

	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0x10")]
	internal int[] hn;

	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0x18")]
	internal int[] v;

	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0x20")]
	internal int[] c;

	[Token(Token = "0x40004CD")]
	[FieldOffset(Offset = "0x28")]
	internal int[] r;

	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0x30")]
	internal int[] u;

	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0x38")]
	internal int[] x;

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x795090", Offset = "0x794290", VA = "0x180795090")]
	private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v)
	{
		return default(int);
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x795A70", Offset = "0x794C70", VA = "0x180795A70")]
	internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z)
	{
		return default(int);
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x795BD0", Offset = "0x794DD0", VA = "0x180795BD0")]
	internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z)
	{
		return default(int);
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x795F40", Offset = "0x795140", VA = "0x180795F40")]
	internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z)
	{
		return default(int);
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x796040", Offset = "0x795240", VA = "0x180796040")]
	private void initWorkArea(int vsize)
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public InfTree()
	{
	}
}
