using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200182D")]
public class EngineInitializerByServer : EngineInitializer
{
	[Token(Token = "0x400E2BE")]
	[FieldOffset(Offset = "0x10")]
	private int[][][] m_decks;

	[Token(Token = "0x400E2BF")]
	[FieldOffset(Offset = "0x18")]
	private int[][] m_rares;

	[Token(Token = "0x400E2C0")]
	private const int maxDecks = 4;

	[Token(Token = "0x400E2C1")]
	[FieldOffset(Offset = "0x20")]
	private int[] repfin;

	[Token(Token = "0x1700171C")]
	public override int myPlayerNum
	{
		[Token(Token = "0x600997B")]
		[Address(RVA = "0xE38AF0", Offset = "0xE37CF0", VA = "0x180E38AF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700171D")]
	public override int firstPlayer
	{
		[Token(Token = "0x600997C")]
		[Address(RVA = "0xE38330", Offset = "0xE37530", VA = "0x180E38330", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700171E")]
	public override int[][] deck0
	{
		[Token(Token = "0x600997D")]
		[Address(RVA = "0xE38000", Offset = "0xE37200", VA = "0x180E38000", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171F")]
	public override int[][] deck1
	{
		[Token(Token = "0x600997E")]
		[Address(RVA = "0xE38070", Offset = "0xE37270", VA = "0x180E38070", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001720")]
	public override int[][] deck2
	{
		[Token(Token = "0x600997F")]
		[Address(RVA = "0xE380E0", Offset = "0xE372E0", VA = "0x180E380E0", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001721")]
	public override int[][] deck3
	{
		[Token(Token = "0x6009980")]
		[Address(RVA = "0xE38150", Offset = "0xE37350", VA = "0x180E38150", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001722")]
	public override uint randSeed
	{
		[Token(Token = "0x6009981")]
		[Address(RVA = "0xE390A0", Offset = "0xE382A0", VA = "0x180E390A0", Slot = "8")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001723")]
	public override Engine.PlayerType myselfType
	{
		[Token(Token = "0x6009982")]
		[Address(RVA = "0xE38C40", Offset = "0xE37E40", VA = "0x180E38C40", Slot = "9")]
		get
		{
			return default(Engine.PlayerType);
		}
	}

	[Token(Token = "0x17001724")]
	public override Engine.PlayerType rivalType
	{
		[Token(Token = "0x6009983")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "10")]
		get
		{
			return default(Engine.PlayerType);
		}
	}

	[Token(Token = "0x17001725")]
	public override Engine.PlayerType myselfPartnerType
	{
		[Token(Token = "0x6009984")]
		[Address(RVA = "0xE38B90", Offset = "0xE37D90", VA = "0x180E38B90", Slot = "11")]
		get
		{
			return default(Engine.PlayerType);
		}
	}

	[Token(Token = "0x17001726")]
	public override Engine.PlayerType rivalPartnerType
	{
		[Token(Token = "0x6009985")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "12")]
		get
		{
			return default(Engine.PlayerType);
		}
	}

	[Token(Token = "0x17001727")]
	public override int fDuelType
	{
		[Token(Token = "0x6009986")]
		[Address(RVA = "0xE38260", Offset = "0xE37460", VA = "0x180E38260", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001728")]
	public override uint limitedType
	{
		[Token(Token = "0x6009987")]
		[Address(RVA = "0xE389F0", Offset = "0xE37BF0", VA = "0x180E389F0", Slot = "14")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001729")]
	public override int[] rare0
	{
		[Token(Token = "0x6009988")]
		[Address(RVA = "0xE39140", Offset = "0xE38340", VA = "0x180E39140", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700172A")]
	public override int[] rare1
	{
		[Token(Token = "0x6009989")]
		[Address(RVA = "0xE391B0", Offset = "0xE383B0", VA = "0x180E391B0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700172B")]
	public override int[] rare2
	{
		[Token(Token = "0x600998A")]
		[Address(RVA = "0xE39210", Offset = "0xE38410", VA = "0x180E39210", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700172C")]
	public override int[] rare3
	{
		[Token(Token = "0x600998B")]
		[Address(RVA = "0xE39270", Offset = "0xE38470", VA = "0x180E39270", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700172D")]
	public override byte[] replayData
	{
		[Token(Token = "0x600998C")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700172E")]
	public override int[] repFinish
	{
		[Token(Token = "0x600998D")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700172F")]
	public override byte[] packedReplay
	{
		[Token(Token = "0x600998E")]
		[Address(RVA = "0xE38D80", Offset = "0xE37F80", VA = "0x180E38D80", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001730")]
	public override uint cpuParam
	{
		[Token(Token = "0x600998F")]
		[Address(RVA = "0xE37B40", Offset = "0xE36D40", VA = "0x180E37B40", Slot = "18")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001731")]
	public override Engine.CpuParam cpuFlag
	{
		[Token(Token = "0x6009990")]
		[Address(RVA = "0xE37A50", Offset = "0xE36C50", VA = "0x180E37A50", Slot = "19")]
		get
		{
			return default(Engine.CpuParam);
		}
	}

	[Token(Token = "0x17001732")]
	public override uint[] cpuParams
	{
		[Token(Token = "0x6009991")]
		[Address(RVA = "0xE37BE0", Offset = "0xE36DE0", VA = "0x180E37BE0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001733")]
	public override int challenge
	{
		[Token(Token = "0x6009992")]
		[Address(RVA = "0xE379B0", Offset = "0xE36BB0", VA = "0x180E379B0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001734")]
	public override int challenge0
	{
		[Token(Token = "0x6009993")]
		[Address(RVA = "0xE37750", Offset = "0xE36950", VA = "0x180E37750", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001735")]
	public override int challenge1
	{
		[Token(Token = "0x6009994")]
		[Address(RVA = "0xE37880", Offset = "0xE36A80", VA = "0x180E37880", Slot = "22")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001736")]
	public override int duelId
	{
		[Token(Token = "0x6009995")]
		[Address(RVA = "0xE381C0", Offset = "0xE373C0", VA = "0x180E381C0", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001737")]
	public override bool noshuffle
	{
		[Token(Token = "0x6009996")]
		[Address(RVA = "0xE38CE0", Offset = "0xE37EE0", VA = "0x180E38CE0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001738")]
	public override bool inputTimer
	{
		[Token(Token = "0x6009997")]
		[Address(RVA = "0xE385C0", Offset = "0xE377C0", VA = "0x180E385C0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001739")]
	public override bool match
	{
		[Token(Token = "0x6009998")]
		[Address(RVA = "0xE38A90", Offset = "0xE37C90", VA = "0x180E38A90", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700173A")]
	public override bool isTagDuel
	{
		[Token(Token = "0x6009999")]
		[Address(RVA = "0xE38660", Offset = "0xE37860", VA = "0x180E38660", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700173B")]
	public override int[] life
	{
		[Token(Token = "0x600999A")]
		[Address(RVA = "0xE38800", Offset = "0xE37A00", VA = "0x180E38800", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700173C")]
	public override int[] hand
	{
		[Token(Token = "0x600999B")]
		[Address(RVA = "0xE383D0", Offset = "0xE375D0", VA = "0x180E383D0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700173D")]
	public override int item
	{
		[Token(Token = "0x600999C")]
		[Address(RVA = "0xE38760", Offset = "0xE37960", VA = "0x180E38760", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700173E")]
	public Dictionary<string, object> duelSettings
	{
		[Token(Token = "0x600999D")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600999E")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600999F")]
	[Address(RVA = "0xE372D0", Offset = "0xE364D0", VA = "0x180E372D0")]
	public EngineInitializerByServer()
	{
	}

	[Token(Token = "0x60099A0")]
	[Address(RVA = "0xE36C50", Offset = "0xE35E50", VA = "0x180E36C50")]
	private void SetupDeckAndRare(List<object> decks, int player, out int[][] dstDeck, out int[] dstRare)
	{
	}

	[Token(Token = "0x60099A1")]
	[Address(RVA = "0xE36A90", Offset = "0xE35C90", VA = "0x180E36A90")]
	private int[] GetRejectedArray(int[] arr, List<int> rejectIndices)
	{
		return null;
	}

	[Token(Token = "0x60099A2")]
	[Address(RVA = "0xE392D0", Offset = "0xE384D0", VA = "0x180E392D0")]
	private int[] objectListToIntArray(List<object> src, bool rejectZero, out List<int> rejectIdxs)
	{
		return null;
	}

	[Token(Token = "0x60099A3")]
	[Address(RVA = "0xE37560", Offset = "0xE36760", VA = "0x180E37560")]
	private int[] dicDeckToIntArray(Dictionary<string, object> dic, string key1, string key2, bool rejectZero, out List<int> rejectIdxs)
	{
		return null;
	}
}
