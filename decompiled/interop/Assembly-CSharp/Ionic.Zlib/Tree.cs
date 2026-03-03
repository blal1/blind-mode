using Il2CppDummyDll;

namespace Ionic.Zlib;

[Token(Token = "0x20000D5")]
internal sealed class Tree
{
	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int HEAP_SIZE;

	[Token(Token = "0x40004D1")]
	[FieldOffset(Offset = "0x8")]
	internal static readonly int[] ExtraLengthBits;

	[Token(Token = "0x40004D2")]
	[FieldOffset(Offset = "0x10")]
	internal static readonly int[] ExtraDistanceBits;

	[Token(Token = "0x40004D3")]
	[FieldOffset(Offset = "0x18")]
	internal static readonly int[] extra_blbits;

	[Token(Token = "0x40004D4")]
	[FieldOffset(Offset = "0x20")]
	internal static readonly sbyte[] bl_order;

	[Token(Token = "0x40004D5")]
	internal const int Buf_size = 16;

	[Token(Token = "0x40004D6")]
	[FieldOffset(Offset = "0x28")]
	private static readonly sbyte[] _dist_code;

	[Token(Token = "0x40004D7")]
	[FieldOffset(Offset = "0x30")]
	internal static readonly sbyte[] LengthCode;

	[Token(Token = "0x40004D8")]
	[FieldOffset(Offset = "0x38")]
	internal static readonly int[] LengthBase;

	[Token(Token = "0x40004D9")]
	[FieldOffset(Offset = "0x40")]
	internal static readonly int[] DistanceBase;

	[Token(Token = "0x40004DA")]
	[FieldOffset(Offset = "0x10")]
	internal short[] dyn_tree;

	[Token(Token = "0x40004DB")]
	[FieldOffset(Offset = "0x18")]
	internal int max_code;

	[Token(Token = "0x40004DC")]
	[FieldOffset(Offset = "0x20")]
	internal StaticTree staticTree;

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x798EE0", Offset = "0x7980E0", VA = "0x180798EE0")]
	internal static int DistanceCode(int dist)
	{
		return default(int);
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x7998D0", Offset = "0x798AD0", VA = "0x1807998D0")]
	internal void gen_bitlen(DeflateManager s)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x799340", Offset = "0x798540", VA = "0x180799340")]
	internal void build_tree(DeflateManager s)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x799D60", Offset = "0x798F60", VA = "0x180799D60")]
	internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x799320", Offset = "0x798520", VA = "0x180799320")]
	internal static int bi_reverse(int code, int len)
	{
		return default(int);
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Tree()
	{
	}
}
