using System.Diagnostics;
using Il2CppDummyDll;

namespace LZ4ps;

[Token(Token = "0x2000101")]
public static class LZ4Codec
{
	[Token(Token = "0x2000102")]
	private class LZ4HC_Data_Structure
	{
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x10")]
		public byte[] src;

		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x18")]
		public int src_base;

		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x1C")]
		public int src_end;

		[Token(Token = "0x4000667")]
		[FieldOffset(Offset = "0x20")]
		public int src_LASTLITERALS;

		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0x28")]
		public byte[] dst;

		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x30")]
		public int dst_base;

		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x34")]
		public int dst_len;

		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x38")]
		public int dst_end;

		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x40")]
		public int[] hashTable;

		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x48")]
		public ushort[] chainTable;

		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x50")]
		public int nextToUpdate;

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public LZ4HC_Data_Structure()
		{
		}
	}

	[Token(Token = "0x4000641")]
	private const int MEMORY_USAGE = 14;

	[Token(Token = "0x4000642")]
	private const int NOTCOMPRESSIBLE_DETECTIONLEVEL = 6;

	[Token(Token = "0x4000643")]
	private const int BLOCK_COPY_LIMIT = 16;

	[Token(Token = "0x4000644")]
	private const int MINMATCH = 4;

	[Token(Token = "0x4000645")]
	private const int SKIPSTRENGTH = 6;

	[Token(Token = "0x4000646")]
	private const int COPYLENGTH = 8;

	[Token(Token = "0x4000647")]
	private const int LASTLITERALS = 5;

	[Token(Token = "0x4000648")]
	private const int MFLIMIT = 12;

	[Token(Token = "0x4000649")]
	private const int MINLENGTH = 13;

	[Token(Token = "0x400064A")]
	private const int MAXD_LOG = 16;

	[Token(Token = "0x400064B")]
	private const int MAXD = 65536;

	[Token(Token = "0x400064C")]
	private const int MAXD_MASK = 65535;

	[Token(Token = "0x400064D")]
	private const int MAX_DISTANCE = 65535;

	[Token(Token = "0x400064E")]
	private const int ML_BITS = 4;

	[Token(Token = "0x400064F")]
	private const int ML_MASK = 15;

	[Token(Token = "0x4000650")]
	private const int RUN_BITS = 4;

	[Token(Token = "0x4000651")]
	private const int RUN_MASK = 15;

	[Token(Token = "0x4000652")]
	private const int STEPSIZE_64 = 8;

	[Token(Token = "0x4000653")]
	private const int STEPSIZE_32 = 4;

	[Token(Token = "0x4000654")]
	private const int LZ4_64KLIMIT = 65547;

	[Token(Token = "0x4000655")]
	private const int HASH_LOG = 12;

	[Token(Token = "0x4000656")]
	private const int HASH_TABLESIZE = 4096;

	[Token(Token = "0x4000657")]
	private const int HASH_ADJUST = 20;

	[Token(Token = "0x4000658")]
	private const int HASH64K_LOG = 13;

	[Token(Token = "0x4000659")]
	private const int HASH64K_TABLESIZE = 8192;

	[Token(Token = "0x400065A")]
	private const int HASH64K_ADJUST = 19;

	[Token(Token = "0x400065B")]
	private const int HASHHC_LOG = 15;

	[Token(Token = "0x400065C")]
	private const int HASHHC_TABLESIZE = 32768;

	[Token(Token = "0x400065D")]
	private const int HASHHC_ADJUST = 17;

	[Token(Token = "0x400065E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int[] DECODER_TABLE_32;

	[Token(Token = "0x400065F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int[] DECODER_TABLE_64;

	[Token(Token = "0x4000660")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int[] DEBRUIJN_TABLE_32;

	[Token(Token = "0x4000661")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int[] DEBRUIJN_TABLE_64;

	[Token(Token = "0x4000662")]
	private const int MAX_NB_ATTEMPTS = 256;

	[Token(Token = "0x4000663")]
	private const int OPTIMAL_ML = 18;

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x8C1070", Offset = "0x8C0270", VA = "0x1808C1070")]
	public static int MaximumOutputLength(int inputLength)
	{
		return default(int);
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x8B4DA0", Offset = "0x8B3FA0", VA = "0x1808B4DA0")]
	internal static void CheckArguments(byte[] input, int inputOffset, ref int inputLength, byte[] output, int outputOffset, ref int outputLength)
	{
	}

	[Token(Token = "0x6000657")]
	[Address(RVA = "0x8B4A60", Offset = "0x8B3C60", VA = "0x1808B4A60")]
	[Conditional("DEBUG")]
	private static void Assert(bool condition, string errorMessage)
	{
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x8C1140", Offset = "0x8C0340", VA = "0x1808C1140")]
	internal static void Poke2(byte[] buffer, int offset, ushort value)
	{
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x8C1090", Offset = "0x8C0290", VA = "0x1808C1090")]
	internal static ushort Peek2(byte[] buffer, int offset)
	{
		return default(ushort);
	}

	[Token(Token = "0x600065A")]
	[Address(RVA = "0x8C10D0", Offset = "0x8C02D0", VA = "0x1808C10D0")]
	internal static uint Peek4(byte[] buffer, int offset)
	{
		return default(uint);
	}

	[Token(Token = "0x600065B")]
	[Address(RVA = "0x8C14F0", Offset = "0x8C06F0", VA = "0x1808C14F0")]
	private static uint Xor4(byte[] buffer, int offset1, int offset2)
	{
		return default(uint);
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x8C15F0", Offset = "0x8C07F0", VA = "0x1808C15F0")]
	private static ulong Xor8(byte[] buffer, int offset1, int offset2)
	{
		return default(ulong);
	}

	[Token(Token = "0x600065D")]
	[Address(RVA = "0x8B6D90", Offset = "0x8B5F90", VA = "0x1808B6D90")]
	private static bool Equal2(byte[] buffer, int offset1, int offset2)
	{
		return default(bool);
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0x8B6E00", Offset = "0x8B6000", VA = "0x1808B6E00")]
	private static bool Equal4(byte[] buffer, int offset1, int offset2)
	{
		return default(bool);
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0x8B4F50", Offset = "0x8B4150", VA = "0x1808B4F50")]
	private static void Copy4(byte[] buf, int src, int dst)
	{
	}

	[Token(Token = "0x6000660")]
	[Address(RVA = "0x8B5000", Offset = "0x8B4200", VA = "0x1808B5000")]
	private static void Copy8(byte[] buf, int src, int dst)
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x8B4AC0", Offset = "0x8B3CC0", VA = "0x1808B4AC0")]
	private static void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len)
	{
	}

	[Token(Token = "0x6000662")]
	[Address(RVA = "0x8C1360", Offset = "0x8C0560", VA = "0x1808C1360")]
	private static int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end)
	{
		return default(int);
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x8C1180", Offset = "0x8C0380", VA = "0x1808C1180")]
	private static int SecureCopy(byte[] buffer, int src, int dst, int dst_end)
	{
		return default(int);
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x8B5F60", Offset = "0x8B5160", VA = "0x1808B5F60")]
	public static int Encode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
	{
		return default(int);
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x8B6250", Offset = "0x8B5450", VA = "0x1808B6250")]
	public static byte[] Encode32(byte[] input, int inputOffset, int inputLength)
	{
		return null;
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x8B6880", Offset = "0x8B5A80", VA = "0x1808B6880")]
	public static int Encode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
	{
		return default(int);
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x8B6B70", Offset = "0x8B5D70", VA = "0x1808B6B70")]
	public static byte[] Encode64(byte[] input, int inputOffset, int inputLength)
	{
		return null;
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0x8B5320", Offset = "0x8B4520", VA = "0x1808B5320")]
	public static int Decode32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength)
	{
		return default(int);
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x8B5150", Offset = "0x8B4350", VA = "0x1808B5150")]
	public static byte[] Decode32(byte[] input, int inputOffset, int inputLength, int outputLength)
	{
		return null;
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x8B5650", Offset = "0x8B4850", VA = "0x1808B5650")]
	public static int Decode64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength, bool knownOutputLength)
	{
		return default(int);
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x8B5980", Offset = "0x8B4B80", VA = "0x1808B5980")]
	public static byte[] Decode64(byte[] input, int inputOffset, int inputLength, int outputLength)
	{
		return null;
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0x8B7280", Offset = "0x8B6480", VA = "0x1808B7280")]
	private static LZ4HC_Data_Structure LZ4HC_Create(byte[] src, int src_0, int src_len, byte[] dst, int dst_0, int dst_len)
	{
		return null;
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x8BDB30", Offset = "0x8BCD30", VA = "0x1808BDB30")]
	private static int LZ4_compressHC_32(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
	{
		return default(int);
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x8B5B50", Offset = "0x8B4D50", VA = "0x1808B5B50")]
	public static int Encode32HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
	{
		return default(int);
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x8B5DE0", Offset = "0x8B4FE0", VA = "0x1808B5DE0")]
	public static byte[] Encode32HC(byte[] input, int inputOffset, int inputLength)
	{
		return null;
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0x8BDBD0", Offset = "0x8BCDD0", VA = "0x1808BDBD0")]
	private static int LZ4_compressHC_64(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
	{
		return default(int);
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0x8B65F0", Offset = "0x8B57F0", VA = "0x1808B65F0")]
	public static int Encode64HC(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength)
	{
		return default(int);
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0x8B6470", Offset = "0x8B5670", VA = "0x1808B6470")]
	public static byte[] Encode64HC(byte[] input, int inputOffset, int inputLength)
	{
		return null;
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0x8BA6F0", Offset = "0x8B98F0", VA = "0x1808BA6F0")]
	private static int LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
	{
		return default(int);
	}

	[Token(Token = "0x6000674")]
	[Address(RVA = "0x8B88A0", Offset = "0x8B7AA0", VA = "0x1808B88A0")]
	private static int LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
	{
		return default(int);
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0x8BE510", Offset = "0x8BD710", VA = "0x1808BE510")]
	private static int LZ4_uncompress_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len)
	{
		return default(int);
	}

	[Token(Token = "0x6000676")]
	[Address(RVA = "0x8BFA40", Offset = "0x8BEC40", VA = "0x1808BFA40")]
	private static int LZ4_uncompress_unknownOutputSize_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
	{
		return default(int);
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x8B84C0", Offset = "0x8B76C0", VA = "0x1808B84C0")]
	private static void LZ4HC_Insert_32(LZ4HC_Data_Structure ctx, int src_p)
	{
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x8B6EC0", Offset = "0x8B60C0", VA = "0x1808B6EC0")]
	private static int LZ4HC_CommonLength_32(LZ4HC_Data_Structure ctx, int p1, int p2)
	{
		return default(int);
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0x8B73F0", Offset = "0x8B65F0", VA = "0x1808B73F0")]
	private static int LZ4HC_InsertAndFindBestMatch_32(LZ4HC_Data_Structure ctx, int src_p, ref int src_match)
	{
		return default(int);
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0x8B7C30", Offset = "0x8B6E30", VA = "0x1808B7C30")]
	private static int LZ4HC_InsertAndGetWiderMatch_32(LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos)
	{
		return default(int);
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0x8BDC70", Offset = "0x8BCE70", VA = "0x1808BDC70")]
	private static int LZ4_encodeSequence_32(LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref, int dst_end)
	{
		return default(int);
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0x8BC730", Offset = "0x8BB930", VA = "0x1808BC730")]
	private static int LZ4_compressHCCtx_32(LZ4HC_Data_Structure ctx)
	{
		return default(int);
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0x8BB690", Offset = "0x8BA890", VA = "0x1808BB690")]
	private static int LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
	{
		return default(int);
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0x8B9750", Offset = "0x8B8950", VA = "0x1808B9750")]
	private static int LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
	{
		return default(int);
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x8BEFD0", Offset = "0x8BE1D0", VA = "0x1808BEFD0")]
	private static int LZ4_uncompress_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len)
	{
		return default(int);
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x8C0570", Offset = "0x8BF770", VA = "0x1808C0570")]
	private static int LZ4_uncompress_unknownOutputSize_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen)
	{
		return default(int);
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0x8B86B0", Offset = "0x8B78B0", VA = "0x1808B86B0")]
	private static void LZ4HC_Insert_64(LZ4HC_Data_Structure ctx, int src_p)
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0x8B7070", Offset = "0x8B6270", VA = "0x1808B7070")]
	private static int LZ4HC_CommonLength_64(LZ4HC_Data_Structure ctx, int p1, int p2)
	{
		return default(int);
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0x8B7810", Offset = "0x8B6A10", VA = "0x1808B7810")]
	private static int LZ4HC_InsertAndFindBestMatch_64(LZ4HC_Data_Structure ctx, int src_p, ref int matchpos)
	{
		return default(int);
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x8B8050", Offset = "0x8B7250", VA = "0x1808B8050")]
	private static int LZ4HC_InsertAndGetWiderMatch_64(LZ4HC_Data_Structure ctx, int src_p, int startLimit, int longest, ref int matchpos, ref int startpos)
	{
		return default(int);
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0x8BE0C0", Offset = "0x8BD2C0", VA = "0x1808BE0C0")]
	private static int LZ4_encodeSequence_64(LZ4HC_Data_Structure ctx, ref int src_p, ref int dst_p, ref int src_anchor, int matchLength, int src_ref)
	{
		return default(int);
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0x8BD140", Offset = "0x8BC340", VA = "0x1808BD140")]
	private static int LZ4_compressHCCtx_64(LZ4HC_Data_Structure ctx)
	{
		return default(int);
	}
}
