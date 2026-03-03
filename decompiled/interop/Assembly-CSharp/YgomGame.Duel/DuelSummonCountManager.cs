using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x20017B4")]
public class DuelSummonCountManager
{
	[Token(Token = "0x20017B5")]
	public enum SummonType
	{
		[Token(Token = "0x400DDDC")]
		None,
		[Token(Token = "0x400DDDD")]
		Normal,
		[Token(Token = "0x400DDDE")]
		NormalWithSet,
		[Token(Token = "0x400DDDF")]
		Set,
		[Token(Token = "0x400DDE0")]
		Reverse,
		[Token(Token = "0x400DDE1")]
		Sp,
		[Token(Token = "0x400DDE2")]
		Dual
	}

	[Token(Token = "0x20017B6")]
	public enum PositionType
	{
		[Token(Token = "0x400DDE4")]
		None,
		[Token(Token = "0x400DDE5")]
		Deck,
		[Token(Token = "0x400DDE6")]
		ExtraDeck,
		[Token(Token = "0x400DDE7")]
		Hand,
		[Token(Token = "0x400DDE8")]
		MonsterZone,
		[Token(Token = "0x400DDE9")]
		MagicZone,
		[Token(Token = "0x400DDEA")]
		Grave,
		[Token(Token = "0x400DDEB")]
		Exclude
	}

	[Token(Token = "0x400DDD3")]
	[FieldOffset(Offset = "0x10")]
	private RunEffectWorker worker;

	[Token(Token = "0x400DDD4")]
	private const int DEF_SUCCESS_SUMMON_NORMAL = 0;

	[Token(Token = "0x400DDD5")]
	private const int DEF_SUCCESS_SUMMON_REVERSE = 2;

	[Token(Token = "0x400DDD6")]
	private const int DEF_SUCCESS_SUMMON_SPECIAL = 4;

	[Token(Token = "0x400DDD7")]
	private const int DEF_SUCCESS_SUMMON_DUAL = 8;

	[Token(Token = "0x400DDD8")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<SummonType, int> mySummonCount;

	[Token(Token = "0x400DDD9")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<SummonType, int> rivalSummonCount;

	[Token(Token = "0x170016BD")]
	public bool isInitialized
	{
		[Token(Token = "0x6009542")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009543")]
		[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6009544")]
	[Address(RVA = "0xDE94F0", Offset = "0xDE86F0", VA = "0x180DE94F0")]
	public static DuelSummonCountManager Create(RunEffectWorker worker)
	{
		return null;
	}

	[Token(Token = "0x6009545")]
	[Address(RVA = "0xDE9740", Offset = "0xDE8940", VA = "0x180DE9740")]
	public void Initialize(RunEffectWorker worker)
	{
	}

	[Token(Token = "0x6009546")]
	[Address(RVA = "0xDE9C80", Offset = "0xDE8E80", VA = "0x180DE9C80")]
	public void Reset()
	{
	}

	[Token(Token = "0x6009547")]
	[Address(RVA = "0xDE92D0", Offset = "0xDE84D0", VA = "0x180DE92D0")]
	public void Count(int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x6009548")]
	[Address(RVA = "0xDE9F20", Offset = "0xDE9120", VA = "0x180DE9F20")]
	private void UpdateCount()
	{
	}

	[Token(Token = "0x6009549")]
	[Address(RVA = "0xDEA040", Offset = "0xDE9240", VA = "0x180DEA040")]
	private void Update(SummonCountSetting.SummonCountInfo countInfo)
	{
	}

	[Token(Token = "0x600954A")]
	[Address(RVA = "0xDE9560", Offset = "0xDE8760", VA = "0x180DE9560")]
	public int GetCount(int cardID, int team)
	{
		return default(int);
	}

	[Token(Token = "0x600954B")]
	[Address(RVA = "0xDE9A60", Offset = "0xDE8C60", VA = "0x180DE9A60")]
	public bool IsTargetPos(int cardID, int pos)
	{
		return default(bool);
	}

	[Token(Token = "0x600954C")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelSummonCountManager()
	{
	}
}
