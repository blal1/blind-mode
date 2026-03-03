using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001751")]
public class AdvantageCalculation : MonoBehaviour
{
	[Token(Token = "0x400DB9B")]
	private const int MAXPLAYERNUM = 4;

	[Token(Token = "0x400DB9C")]
	[FieldOffset(Offset = "0x0")]
	public static int POINT_LEVEL_NORMAL;

	[Token(Token = "0x400DB9D")]
	[FieldOffset(Offset = "0x4")]
	public static int POINT_LEVEL_EFFECT;

	[Token(Token = "0x400DB9E")]
	[FieldOffset(Offset = "0x8")]
	public static int POINT_LEVEL_SYNC;

	[Token(Token = "0x400DB9F")]
	[FieldOffset(Offset = "0xC")]
	public static int POINT_LEVEL_FUSION;

	[Token(Token = "0x400DBA0")]
	[FieldOffset(Offset = "0x10")]
	public static int POINT_LEVEL_RITUAL;

	[Token(Token = "0x400DBA1")]
	[FieldOffset(Offset = "0x14")]
	public static int POINT_LEVEL_PENDULUM;

	[Token(Token = "0x400DBA2")]
	[FieldOffset(Offset = "0x18")]
	public static int POINT_LINK;

	[Token(Token = "0x400DBA3")]
	[FieldOffset(Offset = "0x1C")]
	public static int POINT_RANK;

	[Token(Token = "0x400DBA4")]
	[FieldOffset(Offset = "0x20")]
	public static int POINT_OVERLAY;

	[Token(Token = "0x400DBA5")]
	[FieldOffset(Offset = "0x24")]
	public static int POINT_MONSTER_NORMAL;

	[Token(Token = "0x400DBA6")]
	[FieldOffset(Offset = "0x28")]
	public static int POINT_MONSTER_EFFECT;

	[Token(Token = "0x400DBA7")]
	[FieldOffset(Offset = "0x2C")]
	public static int POINT_MONSTER_LINK;

	[Token(Token = "0x400DBA8")]
	[FieldOffset(Offset = "0x30")]
	public static int POINT_MONSTER_XYZ;

	[Token(Token = "0x400DBA9")]
	[FieldOffset(Offset = "0x34")]
	public static int POINT_MONSTER_SYNC;

	[Token(Token = "0x400DBAA")]
	[FieldOffset(Offset = "0x38")]
	public static int POINT_MONSTER_FUSION;

	[Token(Token = "0x400DBAB")]
	[FieldOffset(Offset = "0x3C")]
	public static int POINT_MONSTER_RITUAL;

	[Token(Token = "0x400DBAC")]
	[FieldOffset(Offset = "0x40")]
	public static int POINT_MONSTER_PENDULUM;

	[Token(Token = "0x400DBAD")]
	[FieldOffset(Offset = "0x44")]
	public static int POINT_MONSTER_OTHER;

	[Token(Token = "0x400DBAE")]
	[FieldOffset(Offset = "0x48")]
	public static int POINT_MONSTER_STRONGEST;

	[Token(Token = "0x400DBAF")]
	[FieldOffset(Offset = "0x4C")]
	public static int POINT_TOKEN;

	[Token(Token = "0x400DBB0")]
	[FieldOffset(Offset = "0x50")]
	public static int POINT_MAGIC_OHTER;

	[Token(Token = "0x400DBB1")]
	[FieldOffset(Offset = "0x54")]
	public static int POINT_MAGIC_CONT;

	[Token(Token = "0x400DBB2")]
	[FieldOffset(Offset = "0x58")]
	public static int POINT_MAGIC_EQUIP;

	[Token(Token = "0x400DBB3")]
	[FieldOffset(Offset = "0x5C")]
	public static int POINT_MAGIC_FIELD;

	[Token(Token = "0x400DBB4")]
	[FieldOffset(Offset = "0x60")]
	public static int POINT_TRAP_OTHER;

	[Token(Token = "0x400DBB5")]
	[FieldOffset(Offset = "0x64")]
	public static int POINT_TRAP_CONT;

	[Token(Token = "0x400DBB6")]
	[FieldOffset(Offset = "0x68")]
	public static int POINT_SET;

	[Token(Token = "0x400DBB7")]
	[FieldOffset(Offset = "0x6C")]
	public static int POINT_HAND;

	[Token(Token = "0x400DBB8")]
	[FieldOffset(Offset = "0x70")]
	public static int POINT_GRAVE;

	[Token(Token = "0x400DBB9")]
	[FieldOffset(Offset = "0x74")]
	public static int POINT_EXCLUDED;

	[Token(Token = "0x400DBBA")]
	[FieldOffset(Offset = "0x78")]
	public static int POINT_PENDULUM_IN_EXTRA;

	[Token(Token = "0x400DBBB")]
	[FieldOffset(Offset = "0x7C")]
	public static int POINT_PENDULUM_IN_PZONE_1;

	[Token(Token = "0x400DBBC")]
	[FieldOffset(Offset = "0x80")]
	public static int POINT_PENDULUM_IN_PZONE_2;

	[Token(Token = "0x400DBBD")]
	[FieldOffset(Offset = "0x84")]
	public static int POINT_PER_COUNTER;

	[Token(Token = "0x400DBBE")]
	[FieldOffset(Offset = "0x88")]
	public static int POINT_PHASE_MAIN1;

	[Token(Token = "0x400DBBF")]
	[FieldOffset(Offset = "0x8C")]
	public static int POINT_PHASE_BATTLE;

	[Token(Token = "0x400DBC0")]
	[FieldOffset(Offset = "0x90")]
	public static int POINT_PHASE_OTHER;

	[Token(Token = "0x400DBC1")]
	[FieldOffset(Offset = "0x94")]
	public static int SAFELINE_REST_LP;

	[Token(Token = "0x400DBC2")]
	[FieldOffset(Offset = "0x98")]
	public static int SAFELINE_REST_DECK;

	[Token(Token = "0x400DBC3")]
	[FieldOffset(Offset = "0x9C")]
	public static int SAFELINE_REST_TIME;

	[Token(Token = "0x400DBE0")]
	[FieldOffset(Offset = "0x100")]
	private int[] pendCardCount;

	[Token(Token = "0x400DBE1")]
	[FieldOffset(Offset = "0x108")]
	private int[] maxATK;

	[Token(Token = "0x400DBE2")]
	[FieldOffset(Offset = "0x110")]
	private int[] maxDEF;

	[Token(Token = "0x17001667")]
	public int[] PointOfNormalMonster
	{
		[Token(Token = "0x6009227")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009228")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001668")]
	public int[] PointOfEffectMonster
	{
		[Token(Token = "0x6009229")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600922A")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001669")]
	public int[] PointOfRitualMonster
	{
		[Token(Token = "0x600922B")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600922C")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700166A")]
	public int[] PointOfFusionMonster
	{
		[Token(Token = "0x600922D")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600922E")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700166B")]
	public int[] PointOfSyncMonster
	{
		[Token(Token = "0x600922F")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009230")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700166C")]
	public int[] PointOfXyzMonster
	{
		[Token(Token = "0x6009231")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009232")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700166D")]
	public int[] PointOfPendMonster
	{
		[Token(Token = "0x6009233")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009234")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700166E")]
	public int[] PointOfLinkMonster
	{
		[Token(Token = "0x6009235")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009236")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700166F")]
	public int[] PointOfToken
	{
		[Token(Token = "0x6009237")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009238")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001670")]
	public int[] PointOfMagicCont
	{
		[Token(Token = "0x6009239")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600923A")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001671")]
	public int[] PointOfMagicEquip
	{
		[Token(Token = "0x600923B")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600923C")]
		[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001672")]
	public int[] PointOfMagicField
	{
		[Token(Token = "0x600923D")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600923E")]
		[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001673")]
	public int[] PointOfMagicOther
	{
		[Token(Token = "0x600923F")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009240")]
		[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001674")]
	public int[] PointOfTrapCont
	{
		[Token(Token = "0x6009241")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009242")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001675")]
	public int[] PointOfTrapOther
	{
		[Token(Token = "0x6009243")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009244")]
		[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001676")]
	public int[] PointOfSetCard
	{
		[Token(Token = "0x6009245")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009246")]
		[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001677")]
	public int[] PointOfPendMagic
	{
		[Token(Token = "0x6009247")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009248")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001678")]
	public int[] PointOfExtra
	{
		[Token(Token = "0x6009249")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600924A")]
		[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001679")]
	public int[] PointOfHand
	{
		[Token(Token = "0x600924B")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600924C")]
		[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700167A")]
	public int[] PointOfGrave
	{
		[Token(Token = "0x600924D")]
		[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600924E")]
		[Address(RVA = "0x42FF70", Offset = "0x42F170", VA = "0x18042FF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700167B")]
	public int[] PointOfExcluded
	{
		[Token(Token = "0x600924F")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009250")]
		[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700167C")]
	public int[] PointOfLife
	{
		[Token(Token = "0x6009251")]
		[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009252")]
		[Address(RVA = "0x42FF90", Offset = "0x42F190", VA = "0x18042FF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700167D")]
	public int[] PointOfStrongestMonster
	{
		[Token(Token = "0x6009253")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009254")]
		[Address(RVA = "0x42FFB0", Offset = "0x42F1B0", VA = "0x18042FFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700167E")]
	public int[] PointOfCounter
	{
		[Token(Token = "0x6009255")]
		[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009256")]
		[Address(RVA = "0x662500", Offset = "0x661700", VA = "0x180662500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700167F")]
	public int[] PointOfPhase
	{
		[Token(Token = "0x6009257")]
		[Address(RVA = "0x5961E0", Offset = "0x5953E0", VA = "0x1805961E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009258")]
		[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001680")]
	public float[] WeightOfDeck
	{
		[Token(Token = "0x6009259")]
		[Address(RVA = "0x49BAE0", Offset = "0x49ACE0", VA = "0x18049BAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600925A")]
		[Address(RVA = "0x49C200", Offset = "0x49B400", VA = "0x18049C200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001681")]
	public float[] WeightOfLP
	{
		[Token(Token = "0x600925B")]
		[Address(RVA = "0x5961D0", Offset = "0x5953D0", VA = "0x1805961D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600925C")]
		[Address(RVA = "0x5FC6E0", Offset = "0x5FB8E0", VA = "0x1805FC6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001682")]
	public float[] WeightOfTime
	{
		[Token(Token = "0x600925D")]
		[Address(RVA = "0x596200", Offset = "0x595400", VA = "0x180596200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600925E")]
		[Address(RVA = "0x5FC6C0", Offset = "0x5FB8C0", VA = "0x1805FC6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001683")]
	public static AdvantageCalculation Instance
	{
		[Token(Token = "0x600925F")]
		[Address(RVA = "0xDC3260", Offset = "0xDC2460", VA = "0x180DC3260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009260")]
		[Address(RVA = "0xDC32C0", Offset = "0xDC24C0", VA = "0x180DC32C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6009261")]
	[Address(RVA = "0xDC1FC0", Offset = "0xDC11C0", VA = "0x180DC1FC0")]
	public static AdvantageCalculation Create(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6009262")]
	[Address(RVA = "0xDC21A0", Offset = "0xDC13A0", VA = "0x180DC21A0")]
	public void EvaluateDuelPoint()
	{
	}

	[Token(Token = "0x6009263")]
	[Address(RVA = "0xDC2350", Offset = "0xDC1550", VA = "0x180DC2350")]
	private void EvaluateFieldCard(int player)
	{
	}

	[Token(Token = "0x6009264")]
	[Address(RVA = "0xDC1AE0", Offset = "0xDC0CE0", VA = "0x180DC1AE0")]
	private void ClearPoint(int player)
	{
	}

	[Token(Token = "0x6009265")]
	[Address(RVA = "0xDC2470", Offset = "0xDC1670", VA = "0x180DC2470")]
	public float GetPoint(int player)
	{
		return default(float);
	}

	[Token(Token = "0x6009266")]
	[Address(RVA = "0xDBFE20", Offset = "0xDBF020", VA = "0x180DBFE20")]
	private int CheckCardPoint(int player, int position)
	{
		return default(int);
	}

	[Token(Token = "0x6009267")]
	[Address(RVA = "0xDC0DC0", Offset = "0xDBFFC0", VA = "0x180DC0DC0")]
	private int CheckMonsterCardPoint(int player, int position)
	{
		return default(int);
	}

	[Token(Token = "0x6009268")]
	[Address(RVA = "0xDC28A0", Offset = "0xDC1AA0", VA = "0x180DC28A0")]
	private bool IsMinusCounter(Engine.CounterType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6009269")]
	[Address(RVA = "0xDC0310", Offset = "0xDBF510", VA = "0x180DC0310")]
	private int CheckCounter(int player, int position)
	{
		return default(int);
	}

	[Token(Token = "0x600926A")]
	[Address(RVA = "0xDC28C0", Offset = "0xDC1AC0", VA = "0x180DC28C0")]
	private void UpdateMaxATKDEF(int player, int position)
	{
	}

	[Token(Token = "0x600926B")]
	[Address(RVA = "0xDC19A0", Offset = "0xDC0BA0", VA = "0x180DC19A0")]
	private int CheckStrongestMonster(int player)
	{
		return default(int);
	}

	[Token(Token = "0x600926C")]
	[Address(RVA = "0xDC09A0", Offset = "0xDBFBA0", VA = "0x180DC09A0")]
	private int CheckMagicTrapCardPoint(int player, int position)
	{
		return default(int);
	}

	[Token(Token = "0x600926D")]
	[Address(RVA = "0xDC06A0", Offset = "0xDBF8A0", VA = "0x180DC06A0")]
	private int CheckExtraDeck(int player)
	{
		return default(int);
	}

	[Token(Token = "0x600926E")]
	[Address(RVA = "0xDC1530", Offset = "0xDC0730", VA = "0x180DC1530")]
	private int CheckPendulumZone(int player, int position)
	{
		return default(int);
	}

	[Token(Token = "0x600926F")]
	[Address(RVA = "0xDC08D0", Offset = "0xDBFAD0", VA = "0x180DC08D0")]
	private int CheckHandCard(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009270")]
	[Address(RVA = "0xDC0800", Offset = "0xDBFA00", VA = "0x180DC0800")]
	private int CheckGraveCard(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009271")]
	[Address(RVA = "0xDC05D0", Offset = "0xDBF7D0", VA = "0x180DC05D0")]
	private int CheckExcludedCard(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009272")]
	[Address(RVA = "0xDC16B0", Offset = "0xDC08B0", VA = "0x180DC16B0")]
	private int CheckPhase(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009273")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
	private bool CheckIfOTK(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x6009274")]
	[Address(RVA = "0xDC04B0", Offset = "0xDBF6B0", VA = "0x180DC04B0")]
	private void CheckDeck(int player)
	{
	}

	[Token(Token = "0x6009275")]
	[Address(RVA = "0xDC17D0", Offset = "0xDC09D0", VA = "0x180DC17D0")]
	private void CheckRestLife(int player0)
	{
	}

	[Token(Token = "0x6009276")]
	[Address(RVA = "0x4C9EF0", Offset = "0x4C90F0", VA = "0x1804C9EF0")]
	private int ErrorMsg(string msg)
	{
		return default(int);
	}

	[Token(Token = "0x6009277")]
	[Address(RVA = "0xDC2DA0", Offset = "0xDC1FA0", VA = "0x180DC2DA0")]
	public AdvantageCalculation()
	{
	}
}
