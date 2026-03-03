using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200182C")]
public abstract class EngineInitializer
{
	[Token(Token = "0x170016F9")]
	public abstract int myPlayerNum
	{
		[Token(Token = "0x6009953")]
		get;
	}

	[Token(Token = "0x170016FA")]
	public int rivalPlayerNum
	{
		[Token(Token = "0x6009954")]
		[Address(RVA = "0xE39EC0", Offset = "0xE390C0", VA = "0x180E39EC0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170016FB")]
	public abstract int firstPlayer
	{
		[Token(Token = "0x6009955")]
		get;
	}

	[Token(Token = "0x170016FC")]
	public abstract int[][] deck0
	{
		[Token(Token = "0x6009956")]
		get;
	}

	[Token(Token = "0x170016FD")]
	public abstract int[][] deck1
	{
		[Token(Token = "0x6009957")]
		get;
	}

	[Token(Token = "0x170016FE")]
	public abstract uint randSeed
	{
		[Token(Token = "0x6009958")]
		get;
	}

	[Token(Token = "0x170016FF")]
	public abstract Engine.PlayerType myselfType
	{
		[Token(Token = "0x6009959")]
		get;
	}

	[Token(Token = "0x17001700")]
	public abstract Engine.PlayerType rivalType
	{
		[Token(Token = "0x600995A")]
		get;
	}

	[Token(Token = "0x17001701")]
	public abstract Engine.PlayerType myselfPartnerType
	{
		[Token(Token = "0x600995B")]
		get;
	}

	[Token(Token = "0x17001702")]
	public abstract Engine.PlayerType rivalPartnerType
	{
		[Token(Token = "0x600995C")]
		get;
	}

	[Token(Token = "0x17001703")]
	public abstract int fDuelType
	{
		[Token(Token = "0x600995D")]
		get;
	}

	[Token(Token = "0x17001704")]
	public abstract uint limitedType
	{
		[Token(Token = "0x600995E")]
		get;
	}

	[Token(Token = "0x17001705")]
	public abstract int[] rare0
	{
		[Token(Token = "0x600995F")]
		get;
	}

	[Token(Token = "0x17001706")]
	public abstract int[] rare1
	{
		[Token(Token = "0x6009960")]
		get;
	}

	[Token(Token = "0x17001707")]
	public abstract byte[] replayData
	{
		[Token(Token = "0x6009961")]
		get;
	}

	[Token(Token = "0x17001708")]
	public abstract uint cpuParam
	{
		[Token(Token = "0x6009962")]
		get;
	}

	[Token(Token = "0x17001709")]
	public abstract Engine.CpuParam cpuFlag
	{
		[Token(Token = "0x6009963")]
		get;
	}

	[Token(Token = "0x1700170A")]
	public virtual int challenge
	{
		[Token(Token = "0x6009964")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700170B")]
	public virtual int challenge0
	{
		[Token(Token = "0x6009965")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700170C")]
	public virtual int challenge1
	{
		[Token(Token = "0x6009966")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "22")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700170D")]
	public virtual int duelId
	{
		[Token(Token = "0x6009967")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "23")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700170E")]
	public virtual bool noshuffle
	{
		[Token(Token = "0x6009968")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700170F")]
	public virtual bool inputTimer
	{
		[Token(Token = "0x6009969")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001710")]
	public virtual byte[] packedReplay
	{
		[Token(Token = "0x600996A")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001711")]
	public virtual int[] repFinish
	{
		[Token(Token = "0x600996B")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001712")]
	public virtual bool match
	{
		[Token(Token = "0x600996C")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001713")]
	public virtual bool isTagDuel
	{
		[Token(Token = "0x600996D")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001714")]
	public virtual int[][] deck2
	{
		[Token(Token = "0x600996E")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001715")]
	public virtual int[][] deck3
	{
		[Token(Token = "0x600996F")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001716")]
	public virtual int[] life
	{
		[Token(Token = "0x6009970")]
		[Address(RVA = "0xE39E50", Offset = "0xE39050", VA = "0x180E39E50", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001717")]
	public virtual uint[] cpuParams
	{
		[Token(Token = "0x6009971")]
		[Address(RVA = "0xE39DA0", Offset = "0xE38FA0", VA = "0x180E39DA0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001718")]
	public virtual int[] rare2
	{
		[Token(Token = "0x6009972")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001719")]
	public virtual int[] rare3
	{
		[Token(Token = "0x6009973")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171A")]
	public virtual int[] hand
	{
		[Token(Token = "0x6009974")]
		[Address(RVA = "0xE39DE0", Offset = "0xE38FE0", VA = "0x180E39DE0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171B")]
	public virtual int item
	{
		[Token(Token = "0x6009975")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6009976")]
	[Address(RVA = "0xE39D40", Offset = "0xE38F40", VA = "0x180E39D40")]
	private int[][] deck(int player)
	{
		return null;
	}

	[Token(Token = "0x6009977")]
	[Address(RVA = "0xE39BB0", Offset = "0xE38DB0", VA = "0x180E39BB0", Slot = "38")]
	public virtual void LoadResources()
	{
	}

	[Token(Token = "0x6009978")]
	[Address(RVA = "0xE39D00", Offset = "0xE38F00", VA = "0x180E39D00", Slot = "39")]
	public virtual bool WaitLoad()
	{
		return default(bool);
	}

	[Token(Token = "0x6009979")]
	[Address(RVA = "0xE394E0", Offset = "0xE386E0", VA = "0x180E394E0")]
	public void InitEngine(Engine.RunEffect runEffect, Engine.IsBusyEffect isBusyEffect, ref RecordManager recmanref)
	{
	}

	[Token(Token = "0x600997A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected EngineInitializer()
	{
	}
}
