using Il2CppDummyDll;

namespace Ionic.Zlib;

[Token(Token = "0x20000CA")]
internal sealed class DeflateManager
{
	[Token(Token = "0x20000CB")]
	internal delegate BlockState CompressFunc(FlushType flush);

	[Token(Token = "0x20000CC")]
	internal class Config
	{
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x10")]
		internal int GoodLength;

		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x14")]
		internal int MaxLazy;

		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x18")]
		internal int NiceLength;

		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x1C")]
		internal int MaxChainLength;

		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x20")]
		internal DeflateFlavor Flavor;

		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Config[] Table;

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x671F40", Offset = "0x671140", VA = "0x180671F40")]
		private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x671960", Offset = "0x670B60", VA = "0x180671960")]
		public static Config Lookup(CompressionLevel level)
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x6719D0", Offset = "0x670BD0", VA = "0x1806719D0")]
		static Config()
		{
		}
	}

	[Token(Token = "0x400040F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int MEM_LEVEL_MAX;

	[Token(Token = "0x4000410")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int MEM_LEVEL_DEFAULT;

	[Token(Token = "0x4000411")]
	[FieldOffset(Offset = "0x10")]
	private CompressFunc DeflateFunction;

	[Token(Token = "0x4000412")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string[] _ErrorMessage;

	[Token(Token = "0x4000413")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int PRESET_DICT;

	[Token(Token = "0x4000414")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int INIT_STATE;

	[Token(Token = "0x4000415")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int BUSY_STATE;

	[Token(Token = "0x4000416")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int FINISH_STATE;

	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x20")]
	private static readonly int Z_DEFLATED;

	[Token(Token = "0x4000418")]
	[FieldOffset(Offset = "0x24")]
	private static readonly int STORED_BLOCK;

	[Token(Token = "0x4000419")]
	[FieldOffset(Offset = "0x28")]
	private static readonly int STATIC_TREES;

	[Token(Token = "0x400041A")]
	[FieldOffset(Offset = "0x2C")]
	private static readonly int DYN_TREES;

	[Token(Token = "0x400041B")]
	[FieldOffset(Offset = "0x30")]
	private static readonly int Z_BINARY;

	[Token(Token = "0x400041C")]
	[FieldOffset(Offset = "0x34")]
	private static readonly int Z_ASCII;

	[Token(Token = "0x400041D")]
	[FieldOffset(Offset = "0x38")]
	private static readonly int Z_UNKNOWN;

	[Token(Token = "0x400041E")]
	[FieldOffset(Offset = "0x3C")]
	private static readonly int Buf_size;

	[Token(Token = "0x400041F")]
	[FieldOffset(Offset = "0x40")]
	private static readonly int MIN_MATCH;

	[Token(Token = "0x4000420")]
	[FieldOffset(Offset = "0x44")]
	private static readonly int MAX_MATCH;

	[Token(Token = "0x4000421")]
	[FieldOffset(Offset = "0x48")]
	private static readonly int MIN_LOOKAHEAD;

	[Token(Token = "0x4000422")]
	[FieldOffset(Offset = "0x4C")]
	private static readonly int HEAP_SIZE;

	[Token(Token = "0x4000423")]
	[FieldOffset(Offset = "0x50")]
	private static readonly int END_BLOCK;

	[Token(Token = "0x4000424")]
	[FieldOffset(Offset = "0x18")]
	internal ZlibCodec _codec;

	[Token(Token = "0x4000425")]
	[FieldOffset(Offset = "0x20")]
	internal int status;

	[Token(Token = "0x4000426")]
	[FieldOffset(Offset = "0x28")]
	internal byte[] pending;

	[Token(Token = "0x4000427")]
	[FieldOffset(Offset = "0x30")]
	internal int nextPending;

	[Token(Token = "0x4000428")]
	[FieldOffset(Offset = "0x34")]
	internal int pendingCount;

	[Token(Token = "0x4000429")]
	[FieldOffset(Offset = "0x38")]
	internal sbyte data_type;

	[Token(Token = "0x400042A")]
	[FieldOffset(Offset = "0x3C")]
	internal int last_flush;

	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x40")]
	internal int w_size;

	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0x44")]
	internal int w_bits;

	[Token(Token = "0x400042D")]
	[FieldOffset(Offset = "0x48")]
	internal int w_mask;

	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0x50")]
	internal byte[] window;

	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0x58")]
	internal int window_size;

	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0x60")]
	internal short[] prev;

	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x68")]
	internal short[] head;

	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x70")]
	internal int ins_h;

	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x74")]
	internal int hash_size;

	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x78")]
	internal int hash_bits;

	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x7C")]
	internal int hash_mask;

	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x80")]
	internal int hash_shift;

	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x84")]
	internal int block_start;

	[Token(Token = "0x4000438")]
	[FieldOffset(Offset = "0x88")]
	private Config config;

	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0x90")]
	internal int match_length;

	[Token(Token = "0x400043A")]
	[FieldOffset(Offset = "0x94")]
	internal int prev_match;

	[Token(Token = "0x400043B")]
	[FieldOffset(Offset = "0x98")]
	internal int match_available;

	[Token(Token = "0x400043C")]
	[FieldOffset(Offset = "0x9C")]
	internal int strstart;

	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0xA0")]
	internal int match_start;

	[Token(Token = "0x400043E")]
	[FieldOffset(Offset = "0xA4")]
	internal int lookahead;

	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0xA8")]
	internal int prev_length;

	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0xAC")]
	internal CompressionLevel compressionLevel;

	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0xB0")]
	internal CompressionStrategy compressionStrategy;

	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0xB8")]
	internal short[] dyn_ltree;

	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0xC0")]
	internal short[] dyn_dtree;

	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0xC8")]
	internal short[] bl_tree;

	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0xD0")]
	internal Tree treeLiterals;

	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0xD8")]
	internal Tree treeDistances;

	[Token(Token = "0x4000447")]
	[FieldOffset(Offset = "0xE0")]
	internal Tree treeBitLengths;

	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0xE8")]
	internal short[] bl_count;

	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0xF0")]
	internal int[] heap;

	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0xF8")]
	internal int heap_len;

	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0xFC")]
	internal int heap_max;

	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0x100")]
	internal sbyte[] depth;

	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0x108")]
	internal int _lengthOffset;

	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0x10C")]
	internal int lit_bufsize;

	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x110")]
	internal int last_lit;

	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0x114")]
	internal int _distanceOffset;

	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x118")]
	internal int opt_len;

	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x11C")]
	internal int static_len;

	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x120")]
	internal int matches;

	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x124")]
	internal int last_eob_len;

	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x128")]
	internal short bi_buf;

	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x12C")]
	internal int bi_valid;

	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x130")]
	private bool Rfc1950BytesEmitted;

	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0x131")]
	private bool _WantRfc1950HeaderBytes;

	[Token(Token = "0x17000054")]
	internal bool WantRfc1950HeaderBytes
	{
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x676680", Offset = "0x675880", VA = "0x180676680")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x677B80", Offset = "0x676D80", VA = "0x180677B80")]
		set
		{
		}
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x6750E0", Offset = "0x6742E0", VA = "0x1806750E0")]
	internal DeflateManager()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x6749B0", Offset = "0x673BB0", VA = "0x1806749B0")]
	private void _InitializeLazyMatch()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x674B00", Offset = "0x673D00", VA = "0x180674B00")]
	private void _InitializeTreeData()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x6747B0", Offset = "0x6739B0", VA = "0x1806747B0")]
	internal void _InitializeBlocks()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x676B80", Offset = "0x675D80", VA = "0x180676B80")]
	internal void pqdownheap(short[] tree, int k)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x674C70", Offset = "0x673E70", VA = "0x180674C70")]
	internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x676E40", Offset = "0x676040", VA = "0x180676E40")]
	internal void scan_tree(short[] tree, int max_code)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x676360", Offset = "0x675560", VA = "0x180676360")]
	internal int build_bl_tree()
	{
		return default(int);
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x6770F0", Offset = "0x6762F0", VA = "0x1806770F0")]
	internal void send_all_trees(int lcodes, int dcodes, int blcodes)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x6777E0", Offset = "0x6769E0", VA = "0x1806777E0")]
	internal void send_tree(short[] tree, int max_code)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x676DF0", Offset = "0x675FF0", VA = "0x180676DF0")]
	private void put_bytes(byte[] p, int start, int len)
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x6773C0", Offset = "0x6765C0", VA = "0x1806773C0")]
	internal void send_code(int c, short[] tree)
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x677260", Offset = "0x676460", VA = "0x180677260")]
	internal void send_bits(int value, int length)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x675640", Offset = "0x674840", VA = "0x180675640")]
	internal void _tr_align()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x675E90", Offset = "0x675090", VA = "0x180675E90")]
	internal bool _tr_tally(int dist, int lc)
	{
		return default(bool);
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x677410", Offset = "0x676610", VA = "0x180677410")]
	internal void send_compressed_block(short[] ltree, short[] dtree)
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x677B90", Offset = "0x676D90", VA = "0x180677B90")]
	internal void set_data_type()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x6761B0", Offset = "0x6753B0", VA = "0x1806761B0")]
	internal void bi_flush()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x676290", Offset = "0x675490", VA = "0x180676290")]
	internal void bi_windup()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x6764F0", Offset = "0x6756F0", VA = "0x1806764F0")]
	internal void copy_block(int buf, int len, bool header)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x676610", Offset = "0x675810", VA = "0x180676610")]
	internal void flush_block_only(bool eof)
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x672590", Offset = "0x671790", VA = "0x180672590")]
	internal BlockState DeflateNone(FlushType flush)
	{
		return default(BlockState);
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x675D10", Offset = "0x674F10", VA = "0x180675D10")]
	internal void _tr_stored_block(int buf, int stored_len, bool eof)
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x675830", Offset = "0x674A30", VA = "0x180675830")]
	internal void _tr_flush_block(int buf, int stored_len, bool eof)
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x675370", Offset = "0x674570", VA = "0x180675370")]
	private void _fillWindow()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x671FA0", Offset = "0x6711A0", VA = "0x180671FA0")]
	internal BlockState DeflateFast(FlushType flush)
	{
		return default(BlockState);
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x672850", Offset = "0x671A50", VA = "0x180672850")]
	internal BlockState DeflateSlow(FlushType flush)
	{
		return default(BlockState);
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x676690", Offset = "0x675890", VA = "0x180676690")]
	internal int longest_match(int cur_match)
	{
		return default(int);
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x673920", Offset = "0x672B20", VA = "0x180673920")]
	internal int Initialize(ZlibCodec codec, CompressionLevel level)
	{
		return default(int);
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x6739B0", Offset = "0x672BB0", VA = "0x1806739B0")]
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits)
	{
		return default(int);
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x673D70", Offset = "0x672F70", VA = "0x180673D70")]
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy)
	{
		return default(int);
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x673A50", Offset = "0x672C50", VA = "0x180673A50")]
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy)
	{
		return default(int);
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x673E10", Offset = "0x673010", VA = "0x180673E10")]
	internal void Reset()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x6737F0", Offset = "0x6729F0", VA = "0x1806737F0")]
	internal int End()
	{
		return default(int);
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x6741B0", Offset = "0x6733B0", VA = "0x1806741B0")]
	private void SetDeflater()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x6746B0", Offset = "0x6738B0", VA = "0x1806746B0")]
	internal int SetParams(CompressionLevel level, CompressionStrategy strategy)
	{
		return default(int);
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x674390", Offset = "0x673590", VA = "0x180674390")]
	internal int SetDictionary(byte[] dictionary)
	{
		return default(int);
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x672F70", Offset = "0x672170", VA = "0x180672F70")]
	internal int Deflate(FlushType flush)
	{
		return default(int);
	}
}
