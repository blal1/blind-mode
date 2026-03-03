using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000EC2")]
public static class DuelpassNetworkUtil
{
	[Token(Token = "0x400A4A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Action onUpdate;

	[Token(Token = "0x17000DC4")]
	public static List<DuelpassRewardContext> Contexts
	{
		[Token(Token = "0x600595A")]
		[Address(RVA = "0x9F0650", Offset = "0x9EF850", VA = "0x1809F0650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005959")]
		[Address(RVA = "0x9F06A0", Offset = "0x9EF8A0", VA = "0x1809F06A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6005956")]
	[Address(RVA = "0x9F0060", Offset = "0x9EF260", VA = "0x1809F0060")]
	public static void RequestReceiveInfo([Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6005957")]
	[Address(RVA = "0x9EFA30", Offset = "0x9EEC30", VA = "0x1809EFA30")]
	public static void Init()
	{
	}

	[Token(Token = "0x6005958")]
	[Address(RVA = "0x9F0410", Offset = "0x9EF610", VA = "0x1809F0410")]
	public static void Update()
	{
	}

	[Token(Token = "0x600595B")]
	[Address(RVA = "0x9F04F0", Offset = "0x9EF6F0", VA = "0x1809F04F0")]
	public static bool WithinThePeriod()
	{
		return default(bool);
	}

	[Token(Token = "0x600595C")]
	[Address(RVA = "0x9F0130", Offset = "0x9EF330", VA = "0x1809F0130")]
	public static bool ResultExists()
	{
		return default(bool);
	}

	[Token(Token = "0x600595D")]
	[Address(RVA = "0x9EED20", Offset = "0x9EDF20", VA = "0x1809EED20")]
	public static List<DuelpassRewardContext> GetDuelpassRewardContextList()
	{
		return null;
	}

	[Token(Token = "0x600595E")]
	[Address(RVA = "0x9EECC0", Offset = "0x9EDEC0", VA = "0x1809EECC0")]
	public static int GetCurrentGrade()
	{
		return default(int);
	}

	[Token(Token = "0x600595F")]
	[Address(RVA = "0x9EF450", Offset = "0x9EE650", VA = "0x1809EF450")]
	public static DuelpassProgressBarContext GetProgressBarContext()
	{
		return null;
	}

	[Token(Token = "0x6005960")]
	[Address(RVA = "0x9EF750", Offset = "0x9EE950", VA = "0x1809EF750")]
	public static DuelpassResultProgressBarContext GetResultProgressBarContext()
	{
		return null;
	}

	[Token(Token = "0x6005961")]
	[Address(RVA = "0x9EF5E0", Offset = "0x9EE7E0", VA = "0x1809EF5E0")]
	public static int GetReceiveableRewardNum()
	{
		return default(int);
	}

	[Token(Token = "0x6005962")]
	[Address(RVA = "0x9EF390", Offset = "0x9EE590", VA = "0x1809EF390")]
	public static int GetLatestAchievedGrade()
	{
		return default(int);
	}

	[Token(Token = "0x6005963")]
	[Address(RVA = "0x9EF8A0", Offset = "0x9EEAA0", VA = "0x1809EF8A0")]
	public static int GetSeasonId()
	{
		return default(int);
	}

	[Token(Token = "0x6005964")]
	[Address(RVA = "0x9EF960", Offset = "0x9EEB60", VA = "0x1809EF960")]
	public static string GetStartTime()
	{
		return null;
	}

	[Token(Token = "0x6005965")]
	[Address(RVA = "0x9EF320", Offset = "0x9EE520", VA = "0x1809EF320")]
	public static string GetEndTime()
	{
		return null;
	}

	[Token(Token = "0x6005966")]
	[Address(RVA = "0x9EF2C0", Offset = "0x9EE4C0", VA = "0x1809EF2C0")]
	public static int GetEndTimeStamp()
	{
		return default(int);
	}

	[Token(Token = "0x6005967")]
	[Address(RVA = "0x9EF9D0", Offset = "0x9EEBD0", VA = "0x1809EF9D0")]
	public static bool HasGoldpass()
	{
		return default(bool);
	}

	[Token(Token = "0x6005968")]
	[Address(RVA = "0x9EF3F0", Offset = "0x9EE5F0", VA = "0x1809EF3F0")]
	public static int GetLimitThresholdTimeStamp()
	{
		return default(int);
	}

	[Token(Token = "0x6005969")]
	[Address(RVA = "0x9EFB00", Offset = "0x9EED00", VA = "0x1809EFB00")]
	public static int IsEmphasis()
	{
		return default(int);
	}

	[Token(Token = "0x600596A")]
	[Address(RVA = "0x9EEB90", Offset = "0x9EDD90", VA = "0x1809EEB90")]
	public static DuelpassRewardContext GetContext(int rewardId)
	{
		return null;
	}

	[Token(Token = "0x600596B")]
	[Address(RVA = "0x9EFBE0", Offset = "0x9EEDE0", VA = "0x1809EFBE0")]
	private static void OnCompleteRecieve(Handle h, Action onSuccess, Action onFaild)
	{
	}

	[Token(Token = "0x600596C")]
	[Address(RVA = "0x9EFB60", Offset = "0x9EED60", VA = "0x1809EFB60")]
	public static void ItemDialog(int rewardId)
	{
	}

	[Token(Token = "0x600596D")]
	[Address(RVA = "0x9EFEF0", Offset = "0x9EF0F0", VA = "0x1809EFEF0")]
	public static void Receive(int id, [Optional] Action onSuccess, [Optional] Action onFaild)
	{
	}

	[Token(Token = "0x600596E")]
	[Address(RVA = "0x9F0220", Offset = "0x9EF420", VA = "0x1809F0220")]
	public static void SingleReceive(int rewardId)
	{
	}

	[Token(Token = "0x600596F")]
	[Address(RVA = "0x9EFDA0", Offset = "0x9EEFA0", VA = "0x1809EFDA0")]
	private static void OnSuccessSingleReceive(DuelpassRewardContext context)
	{
	}

	[Token(Token = "0x6005970")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private static void OnFaildSingleReceive()
	{
	}

	[Token(Token = "0x6005971")]
	[Address(RVA = "0x9EE6A0", Offset = "0x9ED8A0", VA = "0x1809EE6A0")]
	public static void BulkReceive(int seasonId = -1, [Optional] List<DuelpassRewardContext> contexts)
	{
	}

	[Token(Token = "0x6005972")]
	[Address(RVA = "0x9EFCB0", Offset = "0x9EEEB0", VA = "0x1809EFCB0")]
	private static void OnSuccessBulkReceive()
	{
	}

	[Token(Token = "0x6005973")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private static void OnFaildBulkReceive()
	{
	}

	[Token(Token = "0x6005974")]
	[Address(RVA = "0x9EF900", Offset = "0x9EEB00", VA = "0x1809EF900")]
	public static int GetShopId()
	{
		return default(int);
	}

	[Token(Token = "0x6005975")]
	[Address(RVA = "0x9EEA80", Offset = "0x9EDC80", VA = "0x1809EEA80")]
	public static void CheckReceivedItem()
	{
	}
}
